using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evolve {
	struct ViewLayer {
		internal bool layerFood;
		internal bool layerOre;
		internal bool layerGold;
	}
	class Map : Control {
		//// Food Resource Schedule: ////

		// Let foodRegrowthBalance = The food % (0 to 1) a tile has (when fertility is 1) when foodExtraction = foodGrowth (example show foodRegrowthBalance = 0.5)
		internal static readonly int foodRegrowthBalanceNumerator = 7;
		internal static readonly int foodRegrowthBalanceDenomenator = 10; // Divided by 10

		// Let foodProductionBalance = The food % (0 to 1) a tile requires for a creature to survive (foodConsumption = foodProduction) (tileImprovement = 1.0 and farmSkill = average of creature's life)
		internal static readonly int foodProductionBalanceNumerator = 3;    // Percent
		internal static readonly int foodProductionBalanceDenomenator = 10;    // Percent

		// Let foodConsumptionActive = rate of food consumed when active (food/tick) (example show foodConsumptionActive = 0.16 (10 / second)
		// See Creature.cs

		// Let foodConsumptionPassive = rate of food consumed when idle (food/tick) (example show foodConsumptionPassive = .1 (1 / second)
		// See Creature.cs

		// Let skillImprovementRate = The amount the skill improves after each time it's used
		// See Creature.cs

		// Let creatureAge be the initial lifespan of the creatures (example shows creatureAge = 3750 (60 seconds))
		// See Creature.cs

		// Let tHalf = Food regrowth half-life (ticks)	(example show tHalf = 3750 ticks (60s))
		// See Tile.cs

		// Let farmDuration be the duration in ticks for a farming action to complete (example shows farmDuration = 62 (~1 second))
		// See Tile.cs

		// Let fertility = The food quality of the tile (default: 0 to 1)
		// See Tile.cs

		// Let tileImprovement = the tile improvement bonus (from 1.00 multiplier)
		// See Tile.cs

		// Let food = tile's food quantity
		// See Tile.cs
			// food = tile resource
			// food = Fertility * foodMax * (1 - e^( -ln(2) * tick / tHalf) )
			// food = Fertility[units%] * foodMax * (1 - e^( -ln(2) * tick / tHalf) )
			// food = (Fertility[units food] / foodMax) * foodMax * (1 - e^( -ln(2) * tick / tHalf) )
			// food = Fertility[units food] * (1 - e^( -ln(2) * tick / tHalf) )
		
		// Let foodGrowth = Food regrown each tick
		// See Tile.cs
			// foodGrowth = (fertility[units] - food[units]) * (1 - exp( -log(2) * tick / tHalf) );
			// foodGrowth = (foodFertility - food) * (1 - exp( (-693 * ticks) / (tHalf + 1000) ) );

		// Let foodMax = Maximum food limit of a tile when fertility = 1
		// See Tile.cs
			// Let foodGrowth = 1 when
				// fertility = 1
			// foodGrowth = ln(2) * fertility * foodMax * e^( -ln(2) * tick / tHalf) / tHalf 
			// 1 = ln(2) * 1 * foodMax * e^( - ln(2) * tick / tHalf) / tHalf
				// Tick when food is at 99% of 100% when Fertility = 1
					// food = Fertility * foodMax * (1 - e^( -ln(2) * tick / tHalf) )
					// foodMax * 0.99 = 1 * foodMax * (1 - e^( -ln(2) * tick / tHalf) )
					// tick = ln(100) * tHalf / ln(2)
			// foodMax = 100 * tHalf / ln(2)
			// foodMax = 14427 * tHalf / 100			// 144.2695040888963 = 100 / ln(2)
				// Note: When half-life is 60 seconds, foodMax = 541,010 food
				// Max value of Map.tHalf = 148,851

		// Let foodExtraction = rate of food depletion on the tile due to farming activity (food / tick)
			// foodGrowth = ln(2) * fertility * foodMax * e^( -ln(2) * tick / tHalf) / tHalf
			// foodExtraction = ln(2) * 1 * foodMax * e^( -ln(2) * tick / tHalf) / tHalf 
			// Tick when food = foodRegrowthBalance * foodMax
				// food = Fertility * foodMax * (1 - e^( -ln(2) * tick / tHalf) )
				// foodRegrowthBalance * foodMax = 1 * foodMax * (1 - e^( -ln(2) * tick / tHalf) ) 
				// tick = ln( -1 / (foodRegrowthBalance - 1) ) * tHalf  / ln(2)
			// foodExtraction = ln(2) * 1 * foodMax * e^( -ln(2) * ln( -1 / (foodRegrowthBalance - 1) ) * tHalf  / ln(2) / tHalf) / tHalf
			// foodExtraction = ln(2) * foodMax * (1 - foodRegrowthBalance) / tHalf
			// foodExtraction = 693 * foodMax * (foodRegrowthBalanceDenomenator - foodRegrowthBalanceNumerator) / (tHalf * 1000 * foodRegrowthBalanceDenomenator)
				// Note: When foodRegrowthBalance = 0.5, foodExtraction = 50 food per tick
			// Add a improvment modifier
			// foodExtraction = 693 * foodMax * (tileImprovementFoodregrowthDenomenator - tileImprovementFoodregrowthNumerator) * (foodRegrowthBalanceDenomenator - foodRegrowthBalanceNumerator) / (tHalf * 1000 * tileImprovementFoodregrowthDenomenator * foodRegrowthBalanceDenomenator)
	
		//Let creatureAverageFarmSkill = The average farming skill of creatures
		// See Creature.cs
			//When a new creature has half of its parent's skill, farms for half of its life, the creature skill over it's lifetime is: skillImprovementRate * (creatureAge/2) / farmDuration = skillAtDeath - skillAtBirth
			//skillAtBirth = skillAtDeath / 2
			//skillAtBirth = creatureAge * skillImprovementRate / (2 * farmDuration)
			//skillAtDeath = creatureAge * skillImprovementRate / farmDuration
			//creatureAverageFarmSkill = (3 * skillImprovementRate * creatureAge) / (4 * farmDuration)
				//Note: creatureAverageFarmSkill = 45	(30 to 60 over lifetime) when creatureAge = 3750, skillImprovementRate = 1, farmDuration = 62.5

		// Let foodProduction = rate of food produced
		// See Tile.cs
			//foodProduction = (farmSkill / creatureAverageFarmSkill) * tileImprovement * (food / foodMax) * kProduction
			//Let foodProductionBalance = The food on the tile required for a creature to survive when tileImprovement = 1.0 and farmSkill = average of creature's life (less will not produce enough to meet consumption)
			//foodConsumptionActive = foodProduction
								  //= (farmSkill / creatureAverageFarmSkill) * tileImprovement * (food / foodMax) * kProduction
								  //= 1 * 1.0 * foodProductionBalance * kProduction
			//kProduction = foodConsumptionActive / foodProductionBalance
			//foodProduction = (farmSkill / creatureAverageFarmSkill) * tileImprovement * (food / foodMax) * (foodConsumptionActive / foodProductionBalance)
			//foodProduction = (farmSkill * tileImprovement * food * foodConsumptionActive) / (creatureAverageFarmSkill * foodMax * foodProductionBalance)
				//Node: foodProduction = 0.16 (10/second) when farmSkill = 45, tileImprovement = 1, food = foodMax/2, foodConsumptionActive = 0.16, creatureAverageFarmSkill = 45, foodProductionBalance = 0.5
									 //= 0.11 (6.6/second) when farmSkill = 30 (skill at birth)	(requires tile at 75% when foodProductionBalance = 50%)
									 //= 0.21 (13/second) when farmSkill = 60 (skill at death)	(requires tile at 37.5% when foodProductionBalance = 50%)
					//Converting farmSkill to a foodProduction multiplier gives: farmSkill / creatureAverageFarmSkill	(such that at birth creature is 66% effective, and at death creature is 133% effective)



		//// Ore Resource Schedule: ////
		// Let improvementCost = cost to build a lvl 1 improvement (example show improvementCost = 100)
		internal static readonly int baseImprovementCost = 1;

		// Let improvementCostRate = multiplier for each improvement level (example show improvementCostRate = 2)
		internal static readonly float improvementCostRate = 2f;

		// Let oreProductionBalance = ore produced in one mining action when miningSkill = creatureAverageMiningSkill, tileImprovement = 1.0, ore = 100% (example show oreProductionBalance = 10)
		internal static readonly int oreProductionBalance = 10;

		// Let miningDuration = duration in ticks for a mining action to complete (example shows miningDuration = 62.5 (1 second))
		// See Tile.cs

		// Let oreMax = maximum ore on a tile	(example show oreMax = 1000)
		// See Tile.cs

		// Let creatureAverageFarmSkill = The average farming skill of creatures
		// See Creature.cs
		// See Farming resource schedule for derivation
		// creatureAverageMiningSkill = (3 * skillImprovementRate * creatureAge) / (4 * miningDuration)
		//		Note: creatureAverageMiningSkill = 45	(30 to 60 over lifetime) when creatureAge = 3750, skillImprovementRate = 1, miningDuration = 62.5

		//Let oreProduction = rate of ore produced
		// See Tile.cs
		//oreProduction = (miningSkill / creatureAverageMiningSkill) * tileImprovement * (ore / oreMax) * kOreProduction
			//If oreProductionBalance is ore produced in one mining action
			//oreProductionBalance = oreProduction * miningDuration
			//oreProductionBalance / miningDuration = (miningSkill / creatureAverageMiningSkill) * tileImprovement* (ore / oreMax) * kOreProduction
			//oreProduction = (oreProductionBalance / miningDuration) * (miningSkill / creatureAverageMiningSkill) * tileImprovement * (ore / oreMax)
			//oreProduction = (oreProductionBalance * miningSkill * tileImprovement * ore) / (miningDuration * creatureAverageMiningSkill * oreMax)
				//Note: oreProduction = 0.016 when oreProductionBalance = 10, miningSkill = 45, tileImprovement = 1.0, ore = 1000, miningDuration = 62.5, creatureAverageMiningSkill = 45, oreMax = 1000

		// Other:
		private int tileWidth, tileHeight;								// Size of map in tiles
		public Matrix viewTransform;									// Render transform of map
		internal List<Tile> tileList = new List<Tile>();				// List of all tiles
		internal List<Creature> creatureList = new List<Creature>();	// List of all creatures
		public Tile selectedTile;
		private static readonly float creatureSelectTolerance = 1f;
		internal Creature selectedCreature;
		internal ViewLayer viewLayer;
		private int creatureCountMin;
		private Random rand = new Random();

		public Map() {
			SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
			SetStyle(ControlStyles.AllPaintingInWmPaint, true);

			// Generate map
			this.viewLayer = new Evolve.ViewLayer();
			viewLayer.layerOre = true;
			viewLayer.layerFood = true;
			viewLayer.layerGold = true;
			MapOptions mapOptions;
			mapOptions.foodLayerOptions.density = 50;
			mapOptions.foodLayerOptions.mapScale = 0.05f;
			mapOptions.foodLayerOptions.octaves = 1;
			mapOptions.foodLayerOptions.persistence = 0.5f;
			mapOptions.oreLayerOptions.density = 50;
			mapOptions.oreLayerOptions.mapScale = 0.05f;
			mapOptions.oreLayerOptions.octaves = 1;
			mapOptions.oreLayerOptions.persistence = 0.5f;
			mapOptions.goldLayerOptions.density = 50;
			mapOptions.goldLayerOptions.mapScale = 0.05f;
			mapOptions.goldLayerOptions.octaves = 1;
			mapOptions.goldLayerOptions.persistence = 0.5f;

			// Pass rand to creatures
			Creature.rand = rand;

			// Generate map
			Generate(300, 300, 300, mapOptions);

			// View Transform
			viewTransform = new Matrix();

		}

		~Map() {
			tileList.Clear();
		}

		//private static readonly int regenPacketSize = 500;	// Size of packets
		internal int regenPacketCount;						// Number of packets in map

		internal struct MapOptions {
			internal MapLayerOptions foodLayerOptions;
			internal MapLayerOptions oreLayerOptions;
			internal MapLayerOptions goldLayerOptions;
		};

		internal struct MapLayerOptions {
			internal int density;
			internal float mapScale;
			internal int octaves;
			internal float persistence;
		}

		private int regenPacketSize;						// Size of packets

		internal void Generate(int width, int height, int creatures, MapOptions mapOptions) {
			tileList.Clear();
			creatureList.Clear();
			this.tileWidth = width;
			this.tileHeight = height;
			this.pixelWidth = width * Tile.tileSize;
			this.pixelHeight = height * Tile.tileSize;
			int randFoodX = rand.Next() % 255;
			int randFoodY = rand.Next() % 255;
			int randOreX = rand.Next() % 255;
			int randOreY = rand.Next() % 255;
			int randGoldX = rand.Next() % 255;
			int randGoldY = rand.Next() % 255;

			// Generate tiles
			for(int tileY = 0; tileY < height; tileY++) {
				for(int tileX = 0; tileX < width; tileX++) {
					tileList.Add(new Tile(tileX, tileY,
						Math.Abs((float)Perlin.OctavePerlin((double)tileX * mapOptions.foodLayerOptions.mapScale + randOreX,  (double)tileY * mapOptions.foodLayerOptions.mapScale + randOreY,  0, mapOptions.foodLayerOptions.octaves,  mapOptions.foodLayerOptions.persistence)),
						Math.Abs((float)Perlin.OctavePerlin((double)tileX * mapOptions.oreLayerOptions.mapScale + randFoodX, (double)tileY * mapOptions.oreLayerOptions.mapScale + randFoodY, 0, mapOptions.oreLayerOptions.octaves, mapOptions.oreLayerOptions.persistence)),
						Math.Abs((float)Perlin.OctavePerlin((double)tileX * mapOptions.goldLayerOptions.mapScale + randGoldX, (double)tileY * mapOptions.goldLayerOptions.mapScale + randGoldY, 0, mapOptions.goldLayerOptions.octaves, mapOptions.goldLayerOptions.persistence)),
						this.viewLayer, rand, this));
						//(int)(Math.Abs((float)Perlin.OctavePerlin((double)tileX * mapOptions.foodLayerOptions.mapScale + randOreX,	(double)tileY * mapOptions.foodLayerOptions.mapScale + randOreY,  0, mapOptions.oreLayerOptions.octaves,  mapOptions.oreLayerOptions.persistence))  * 255), 
						//(int)(Math.Abs((float)Perlin.OctavePerlin((double)tileX * mapOptions.foodLayerOptions.mapScale + randFoodX,	(double)tileY * mapOptions.foodLayerOptions.mapScale + randFoodY, 0, mapOptions.foodLayerOptions.octaves, mapOptions.foodLayerOptions.persistence)) * 255), 
						//(int)(Math.Abs((float)Perlin.OctavePerlin((double)tileX * mapOptions.goldLayerOptions.mapScale + randGoldX,	(double)tileY * mapOptions.goldLayerOptions.mapScale + randGoldY, 0, mapOptions.goldLayerOptions.octaves, mapOptions.goldLayerOptions.persistence)) * 255), 
				}
			}
			// Update map density
			//SetMapFoodDensity(mapOptions.foodLayerOptions.density);
			//SetMapOreDensity(mapOptions.oreLayerOptions.density);
			//SetMapGoldDensity(mapOptions.goldLayerOptions.density);
			// Update Tiles with new density
			foreach(Tile tile in tileList) {
				tile.UpdateBrush(viewLayer);
			}

			// Generate creatures
			creatureCountMin = creatures;
			generateCreatures(creatures);

			// Divide sections for regeneration
			regenPacketSize = tileWidth * tileHeight / 100 > 0 ? tileWidth * tileHeight / 100 : 1;
			//regenPacketCount = tileWidth * tileHeight / regenPacketSize + (tileWidth * tileHeight % regenPacketSize > 0 ? 1 : 0);
			regenPacketCount = tileWidth * tileHeight / regenPacketSize;
		}

		private void generateCreatures(int creatures) {
			for(UInt16 i = 0; i < creatures; i++) {
				creatureList.Add(new Creature(rand.Next() % pixelWidth, rand.Next() % pixelHeight));
			}
		}

		internal void SetMapFoodDensity(int percentDensity) {
			// Compute actual map density
			long densityActual = 0;
			foreach(Tile tile in tileList) {
				densityActual += tile.food;
			}
			densityActual /= tileList.Count;
			// Calculate desired density
			int densityDesired = (int)((long)percentDensity * int.MaxValue / 100);
			// Adjust for desired density
			float densityAdjustment = (float)densityDesired / (float)densityActual;
			foreach(Tile tile in tileList) {
				if((tile.food = (int)(densityAdjustment * tile.food)) < 0) {
					tile.food = int.MaxValue;
				}
				tile.foodFertility = tile.food;
			}
		}

		internal void SetMapOreDensity(int percentDensity) {
			// Compute actual map density
			int densityActual = 0;
			foreach(Tile tile in tileList) {
				densityActual += tile.ore;
			}
			densityActual /= tileList.Count;
			// Calculate desired density
			int densityDesired = (int)((long)percentDensity * (long)(int.MaxValue) / 100);
			// Adjust for desired density
			int densityAdjustment = densityDesired / densityActual;
			foreach(Tile tile in tileList) {
				if((tile.ore *= densityAdjustment) < 0) {
					tile.ore = int.MaxValue;
				}
				tile.oreFertility = tile.ore;
			}
		}

		internal void SetMapGoldDensity(int percentDensity) {
			// Compute actual map density
			int densityActual = 0;
			foreach(Tile tile in tileList) {
				densityActual += tile.gold;
			}
			densityActual /= tileList.Count;
			// Calculate desired density
			int densityDesired = (int)((long)percentDensity * (long)(int.MaxValue) / 100);
			// Adjust for desired density
			int densityAdjustment = densityDesired / densityActual;
			foreach(Tile tile in tileList) {
				if((tile.gold *= densityAdjustment) < 0) {
					tile.gold = int.MaxValue;
				}
				tile.goldFertility = tile.gold;
			}
		}

		public override void Refresh() {
			base.Refresh();
		}

		private static int lastTick;
		internal static int lastFrameRate;
		private static int currentFrameRate;

		internal void Draw(Graphics g) {
			g.Transform = viewTransform;
			// Draw Tiles
			foreach(Tile tileToDraw in tileList) {
				tileToDraw.DrawLand(g);
			}
			foreach(Tile tileToDraw in tileList) {
				tileToDraw.DrawBorder(g);
			}

			if(selectedCreature != null) {
				// Draw Selected Creature
				g.DrawEllipse(Pens.White, selectedCreature.X - selectedCreature.bodySize / 2 - 1, selectedCreature.Y - selectedCreature.bodySize / 2 - 1, selectedCreature.bodySize + 2, selectedCreature.bodySize + 2);
			} else if(selectedTile != null) {
				// Draw Selected Tile
				g.DrawRectangle(Pens.White, selectedTile.tileX * Tile.tileSize, selectedTile.tileY * Tile.tileSize, Tile.tileSize, Tile.tileSize);
			}

			// Draw Creatures
			foreach(Creature creature in creatureList) {
				creature.Draw(g);
			}
			
			// Draw Text Information
			if(hoveredTile != null) {
				g.DrawString(String.Format("F: {0:0.}%\nO: {1:0.}%\nG: {2:0.}%", (long)hoveredTile.food * 100 / Tile.foodMax, (long)hoveredTile.ore * 100 / int.MaxValue, (long)hoveredTile.gold * 100 / int.MaxValue), tileInfoFont, Brushes.White, hoveredTile.landRectangle);
			}
		}

		static readonly Font tileInfoFont = new Font("Arial", 2);
		internal Tile hoveredTile;
		internal int pixelWidth, pixelHeight;

		// returns tile under mouse
		public Tile getTileFromMouse(Point mousePos) {
			mousePos.X -= Convert.ToInt32(viewTransform.OffsetX);
			mousePos.Y -= Convert.ToInt32(viewTransform.OffsetY);
			mousePos.X = Convert.ToInt32(mousePos.X / viewTransform.Elements[0]);
			mousePos.Y = Convert.ToInt32(mousePos.Y / viewTransform.Elements[0]);
			return getTile(mousePos);
		}

		public Tile getTile(Point pixelPoint) {
			if(pixelPoint.Y / Tile.tileSize * tileWidth + pixelPoint.X / Tile.tileSize >= 0 && pixelPoint.Y / Tile.tileSize * tileWidth + pixelPoint.X / Tile.tileSize < tileList.Count) {
				return tileList[pixelPoint.Y / Tile.tileSize * tileWidth + pixelPoint.X / Tile.tileSize];
			} else {
				return null;
			}
		}

		// Return tile of tile corrdinates
		public Tile getTile(int tileX, int tileY) {
			if(tileX + tileY * tileHeight >= 0 && tileX + tileY * tileHeight < tileList.Count) {
				return tileList[tileX + tileY * tileHeight];
			} else {
				return null;
			}
		}

		public Tile getTile(Creature creature) {
			creature.currentTile = getTile(creature.position);
			return creature.currentTile;
		}

		// Returns the creature given a mouse position on the screen

		public Creature getCreatureFromMouse(Point mousePos) {
			mousePos.X -= Convert.ToInt32(viewTransform.OffsetX);
			mousePos.Y -= Convert.ToInt32(viewTransform.OffsetY);
			mousePos.X = Convert.ToInt32(mousePos.X / viewTransform.Elements[0]);
			mousePos.Y = Convert.ToInt32(mousePos.Y / viewTransform.Elements[0]);
			return getCreature(mousePos);
		}

		public Creature getCreature(Point pos) {
			foreach(Creature creature in creatureList) {
				if(Math.Abs(pos.X - creature.X) < creature.bodySize * creatureSelectTolerance && Math.Abs(pos.Y - creature.Y) < creature.bodySize * creatureSelectTolerance) {
					return creature;
				}
			}
			return null;
		}

		private int regenTilePacketIndex = 0;	// Index of which packet group to update next

		// Update all tiles on map in packet groups
		public void TileUpdate() {
			if(regenTilePacketIndex < regenPacketCount) {
				for(int i = 0; i < regenPacketSize; i++) {
					tileList[i + regenTilePacketIndex * regenPacketSize].Update(this);
				}
				regenTilePacketIndex++;
			} else {
				for(int i = regenTilePacketIndex * regenPacketSize; i < tileList.Count; i++) {
					tileList[i].Update(this);
				}
				regenTilePacketIndex = 0;
			}
		}

		protected override void OnPaint(PaintEventArgs e) {
			base.OnPaint(e);
			Graphics g = e.Graphics;
			Draw(g);
		}

		//public void RenderTimer_Tick(object sender, EventArgs e) {
		//	TileUpdate();
		//	Invalidate();
		//}

		internal void UpdateTick() {
			// Update Tiles
			TileUpdate();
			// Update Creatures
			for(int i = 0; i < creatureList.Count; i++) {
				// Perform action
				creatureList[i].update(this);
				// Perform requests
				switch(creatureList[i].request) {
					case Creature.Request.KILLSELF:
						if(creatureList[i].property != null) {
							creatureList[i].property.creatureOwner = null;								// Release property rights
						}
						creatureList[i].currentTile.creatureResidentList.Remove(creatureList[i]);	// Creature is no longer standing in the Tile
						creatureList.RemoveAt(i);
						break;
					case Creature.Request.REPRODUCE:
						getTile(creatureList[i]);
						creatureList[i].currentTile.creatureResidentList.Remove(creatureList[i]);
						// Create creature
						Creature newCreature = new Creature(creatureList[i].position.X, creatureList[i].position.Y, creatureList[i]);
						// make creature move to random position
						newCreature.moveTarget.X += rand.Next() % 40 - 20;
						newCreature.moveTarget.Y += rand.Next() % 40 - 20;
						newCreature.activity = Creature.Activity.MOVERANDOM;
						// Add to list
						creatureList.Add(newCreature);
						// Complete request
						creatureList[i].request = Creature.Request.NONE;
						break;
					case Creature.Request.NONE:
						break;
				}
			}
			// Ensure minimum number of creatures
			if(creatureList.Count < creatureCountMin) {
				generateCreatures(creatureCountMin - creatureList.Count);
			}
			// Update map graphics
			Invalidate();

			// Calculate framerate
			if(System.Environment.TickCount - lastTick >= 1000) {
				lastFrameRate = currentFrameRate;
				currentFrameRate = 0;
				lastTick = System.Environment.TickCount;
			}
			currentFrameRate++;
		}

	}
}
