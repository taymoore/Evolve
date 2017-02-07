using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evolve {
	class Tile {
		// Let tHalf = Food regrowth half-life (ticks)
		internal static readonly int tHalf = 12000 / (1000 / MainWindow.tickRatems);

		// Let tileImprovement = the tile improvement bonus (from 1.00 multiplier)
		// Affects extraction rate
		internal int tileFoodImprovementNumerator = 0;
		internal static readonly int tileFoodImprovementDenomenator = 10;   // divided by 10

		internal int tileOreImprovementNumerator = 0;
		internal static readonly int tileOreImprovementDenomenator = 10;   // divided by 10

		// Let tileImprovementCost = cost to improve the tile
		//	internal int tileImprovementCost = (tileFoodImprovementNumerator + tileOreImprovementNumerator) * 5

		// Let fertility = The food quality of the tile (0 to 1)
		internal int foodFertility;	// In units food
		internal int oreFertility;	// In units food
		internal int goldFertility; // In units food

		// Let foodMax = Maximum food limit of a tile when fertility = 1
		// foodMax = 100 * tHalf / ln(2)
		internal static readonly int foodMax = 14427 * tHalf / 100;
		// Let oreMax = maximum ore on a tile	(example show oreMax = 1000)
		internal static readonly int oreMax = 1000;
		internal static readonly int goldMax = foodMax;

		// Let food = tile's food quantity
		internal int food;
		internal int ore;
		internal int gold;

		// Let foodGrowth = Food regrown each tick
		private void regrowTile() {
			// foodGrowth = (foodFertility - food) * (1 - exp( (-693 * ticks) / (tHalf + 1000) ) );
			food += (int)((foodFertility - food) * (1 - Math.Exp((-693 * map.regenPacketCount) / (tHalf * 1000))));
			UpdateBrush(map.viewLayer);
		}

		// Let farmDuration = duration in ticks for a farming action to complete
		internal static readonly int farmDuration = 50;	// 5 seconds

		//Let miningDuration = duration in ticks for a mining action to complete
		internal static readonly int miningDuration = 100;  // 10 seconds

		// Let recoverDuration = duration in ticks required to recover after a fight
		internal static readonly int recoverDuration = 10;  // 1 second for each hp lost. See Creature.recover()

		// Let tileImprovementFoodregrowth = rate to slow down consumption
		internal int tileImprovementFoodregrowthNumerator = 0;
		internal static readonly int tileImprovementFoodregrowthDenomenator = 100;

		// Let foodExtraction = rate of food depletion on the tile due to farming activity (food / tick)
		// Let foodProduction = rate of food produced (food / tick)
			// We multiply these by farmDuration to get amount extracted or produced in one farm activity
		public int farm(Creature creature, ViewLayer viewLayer) {
			// foodExtraction = ln(2) * foodMax * foodRegrowthModifier * (1 - foodRegrowthBalance) / tHalf
			// foodExtraction = 693 * foodMax * (tileImprovementFoodregrowthDenomenator - tileImprovementFoodregrowthNumerator) * (foodRegrowthBalanceDenomenator - foodRegrowthBalanceNumerator) / (tHalf * 1000 * tileImprovementFoodregrowthDenomenator * foodRegrowthBalanceDenomenator)
			food -= (int)(693L * foodMax * (tileImprovementFoodregrowthDenomenator - tileImprovementFoodregrowthNumerator) * (Map.foodRegrowthBalanceDenomenator - Map.foodRegrowthBalanceNumerator) * farmDuration / (tHalf * 1000L * tileImprovementFoodregrowthDenomenator * Map.foodRegrowthBalanceDenomenator));
			if(food < 0) {
				food = 0;
			}
			UpdateBrush(viewLayer);

			// foodProduction = (farmSkill * tileImprovement * food * foodConsumptionActive) / (creatureAverageFarmSkill * foodMax * foodProductionBalance)
			return (int)(((long)creature.farmSkill				  * (tileFoodImprovementDenomenator + tileFoodImprovementNumerator) * food    * Creature.foodConsumptionActiveNumerator   * Map.foodProductionBalanceDenomenator * farmDuration) / 
						 ((long)Creature.creatureAverageFarmSkill * tileFoodImprovementDenomenator								* foodMax * Creature.foodConsumptionActiveDenomenator * Map.foodProductionBalanceNumerator));
		}

		public int mine(Creature creature, ViewLayer viewLayer) {
			// Let oreProduction = rate of ore produced
			// oreProduction = (oreProductionBalance * miningSkill * tileImprovement * ore) / (miningDuration * creatureAverageMiningSkill * oreMax)
			int oreProduction = (Map.oreProductionBalance * creature.mineSkill * (tileOreImprovementDenomenator + tileOreImprovementNumerator) * ore) / (miningDuration * Creature.creatureAverageMiningSkill * oreMax);

			ore -= oreProduction;

			return oreProduction;

			//int initialOre = this.ore;
			//ore -= (int)((long)creature.mineSkill++ * initialOre / int.MaxValue);
			//UpdateBrush(viewLayer);
			//return (initialOre - ore);
		}

		public int tileX { get; }
		public int tileY { get; }
		private byte bodyR {
			get {
				return Convert.ToByte((long)ore * 255 / oreMax);
			}
		}
		private byte bodyG {
			get {
				return Convert.ToByte((long)food * 255 / foodMax);
			}
		}
		private byte bodyB {
			get {
				return Convert.ToByte((long)gold * 255 / int.MaxValue);
			}
		}
		private SolidBrush brush;
		private Pen pen;
		internal Rectangle landRectangle { get; }
		private Rectangle borderRectangle;
		internal List<Creature> creatureResidentList = new List<Creature>();        // All creatures currently standing on this tile
		internal Creature creatureOwner = null;

		public int pixelX {
			get {
				return tileX * tileSize;
			}
		}

		public int pixelY {
			get {
				return tileY * tileSize;
			}
		}

		internal static readonly int tileSize = 10;

		private Map map;

		public Tile(int X, int Y, float food, float ore, float gold, ViewLayer viewLayer, Random rand, Map map) {
			// Record map
			this.map = map;

			// Record location
			this.tileX = X;
			this.tileY = Y;

			//ore /= int.MaxValue / 100;
			gold /= int.MaxValue / 100;

			// Assign Food
			//food = (int)(food / (long)int.MaxValue * 100);
			if(food < 0) {
				throw new System.ArgumentException("Creating tile with negative food");
			}
			this.foodFertility = (int)(food * foodMax);
			this.food = foodFertility;

			// Assign Ore
			if(ore < 0) {
				throw new System.ArgumentException("Creating tile with negative ore");
			}
			this.oreFertility = (int)(ore * oreMax);
			this.ore = oreFertility;

			// Assign Gold
			if(gold < 0) {
				throw new System.ArgumentException("Creating tile with negative gold");
			}
			this.goldFertility = (int)(gold * goldMax);
			this.gold = goldFertility;


			brush = new SolidBrush(Color.FromArgb(255, viewLayer.layerOre?bodyR:0, viewLayer.layerFood?bodyG:0, viewLayer.layerGold?bodyB:0));
			pen = new Pen(Color.FromArgb(255, rand.Next() % 256, rand.Next() % 256, rand.Next() % 256));

			landRectangle = new Rectangle(X * tileSize, Y * tileSize, tileSize, tileSize);
			borderRectangle = new Rectangle(X * tileSize + 1, Y * tileSize + 1, tileSize - 1, tileSize - 1);

			// Create grass rectangles
			grassRectangle = new Point[10];
			for(int i = 0; i < grassRectangle.Count(); i++) {
				//grassRectangle[i] = new Point(rand.Next() % (tileSize - 6) + pixelX, rand.Next() % (tileSize - 6) + pixelY);
				//grassRectangle[i] = new Point(rand.Next() % (tileSize - 6) + pixelX, rand.Next() % (tileSize - 6) + pixelY);
			}
		}

		~Tile() {
			brush.Dispose();
		}

		internal void UpdateBrush(ViewLayer viewLayer) {
			brush.Color = Color.FromArgb(255, viewLayer.layerOre?bodyR:0, viewLayer.layerFood?bodyG:0, viewLayer.layerGold?bodyB:0);
		}

		internal void UpdateBorder(byte R, byte G, byte B) {
			pen.Color = Color.FromArgb(255, R, G, B);
		}

		internal void Dispose() {
			throw new NotImplementedException();
		}

		//private Point grassPoint = new Point(0, 0);
		private static Image grassImage = Properties.Resources.grass;
		private Point[] grassRectangle;

		internal void DrawLand(Graphics graphics) {
			graphics.FillRectangle(brush, landRectangle);
			for(int i = 2; food > (i * foodMax) / 10; i++) {
				//graphics.DrawImage(grassImage, grassRectangle[i]);
			}
		}

		internal void DrawBorder(Graphics graphics) {
			if(creatureOwner != null) {
				graphics.DrawRectangle(pen, borderRectangle);
			}
		}

		internal void Update(Map map) {
			// Regrow resources
			regrowTile();


			//// Each tick will increase by  0.001%
			//food += (foodFertility - food) * map.regenPacketCount / 100000;
			//// Each tick will increase by  0.0005%
			//ore += (oreFertility - ore) * map.regenPacketCount / 200000;

			//// Each tick will increase by  0.01%
			//food += (foodGrowth - food) * map.regenPacketCount / 10000;
			//// Each tick will increase by  0.005%
			//ore += (oreGrowth - ore) * map.regenPacketCount / 20000;
			// Each tick will increase by  0.001%
			//ore += (oreGrowth - ore) * map.regenPacketCount / 100000;

			// Update tile colour
			UpdateBrush(map.viewLayer);
		}
	}
}
