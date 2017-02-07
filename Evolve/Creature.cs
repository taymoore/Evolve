using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolve {
	class Creature {
		// Let skillImprovementRate = The amount the skill improves after each time it's used
		internal static readonly int skillImprovementRate = 1;

		// Let creatureAge be the initial lifespan of the creatures (example shows creatureAge = 600 (30 seconds))
		internal static readonly int creatureAgeMax = 300;
		private int creatureAge = 0;

		// Let creatureAverageFarmSkill = The average expected farming skill of creatures
		//creatureAverageFarmSkill = (3 * skillImprovementRate * creatureAge) / (4 * farmDuration)
		internal static readonly int creatureAverageFarmSkill = (3 * skillImprovementRate * creatureAgeMax) / (4 * Tile.farmDuration);

		// Let creatureAverageFarmSkill = The average farming skill of creatures
		// creatureAverageMiningSkill = (3 * skillImprovementRate * creatureAge) / (4 * miningDuration)
		internal static readonly int creatureAverageMiningSkill = (3 * skillImprovementRate * creatureAgeMax) / (4 * Tile.miningDuration);

		// Let foodConsumptionActive = rate of food consumed when active (food/tick) (example show foodConsumptionActive = 1 (10 / second)
		// Since we consume 1 food every 1/foodConsumptionActive = 1 ticks, we consume 1 food every 1 / 1 ticks
		internal static readonly int foodConsumptionActiveNumerator = 8;
		internal static readonly int foodConsumptionActiveDenomenator = 10;
		// Let foodConsumptionPassive = rate of food consumed when idle (food/tick) (example show foodConsumptionPassive = .1 (1 / second)
		// Since we consume 1 food every 1/foodConsumptionPassive = 10 ticks, we consume 1 food every 1 / 10 ticks
		internal static readonly int foodConsumptionPassiveNumerator = 3;
		internal static readonly int foodConsumptionPassiveDenomenator = 10;

		// Let foodForChild = food needed to have a child
		internal static readonly int foodForChild = 200;

		// Fighting
		internal int maxHp = 10;
		internal int hp = 10;
		internal int fightSkill;	// How much dmg I do each round

		private int foodConsumptionIndex = 0;
		private void consumeResources() {
			switch(activity) {
					// Active Action
				case Activity.FARM:
				case Activity.MINE:
					foodConsumptionIndex += foodConsumptionActiveNumerator;
					if(foodConsumptionIndex >= foodConsumptionActiveDenomenator) {
						food--;
						foodConsumptionIndex -= foodConsumptionActiveDenomenator;
					}
					break;
					
					// Passive Action
				case Activity.MOVERANDOM:
				case Activity.MOVETOFOOD:
				case Activity.MOVETOORE:
					foodConsumptionIndex += foodConsumptionPassiveNumerator;
					if(foodConsumptionIndex >= foodConsumptionPassiveDenomenator) {
						food--;
						foodConsumptionIndex -= foodConsumptionPassiveDenomenator;
					}
					break;

					// Doing nothing
				case Activity.THINK:
				case Activity.TRADE:
					// Don't consume
					break;
			}
			if(food < 0) {
				request = Request.KILLSELF;
			}
		}

		private static readonly uint bodySizeDefault = 4;
		public uint bodySize;
		internal MainNet mainNet;
		internal Tile currentTile;
		private Brush brush;				// Body Colour
		private Pen pen;						// Circle Colour
		public Point position;                  // Location of creature in pixel corrdinates (before render transformation)
		internal static Random rand;
		internal Tile property = null;			// Land owned by the creature

		public int X {
			get {
				return position.X;
			}
			set {
				position.X = value;
			}
		}

		public int Y {
			get {
				return position.Y;
			}
			set {
				position.Y = value;
			}
		}

		// Appearance
		internal byte bodyR, bodyG, bodyB;
		internal float foodValueForLooting = 1;
		internal float oreValueForLooting = 1;
		Tribe tribe;

		public Creature(int posX, int posY, Creature creature = null) {
			bodySize = bodySizeDefault;
			position.X = posX;
			position.Y = posY;
			moveTarget.X = posX;
			moveTarget.Y = posY;
			pen = new Pen(Color.FromArgb(255, 0, 0, 0));

			// Set request
			request = Request.NONE;

			// Set activity
			activity = Activity.THINK;

			// Set skills
			if(creature != null) {
				this.farmSkill = creature.farmSkill * 5 / 10;
				this.mineSkill = creature.mineSkill * 5 / 10;
				this.fightSkill = creature.fightSkill * 5 / 10;
				if(fightSkill < 10) {
					fightSkill = 10;
				}
			} else {
				this.farmSkill = creatureAverageFarmSkill;
				this.mineSkill = creatureAverageMiningSkill;
				this.fightSkill =  10;
			}

			// Set resources
			if(creature != null) {
				// Take resources from parent
				this.food = creature.food / 2;
				creature.food /= 2;
				this.ore = creature.ore / 2;
				creature.ore /= 2;
			} else {
				// Set initial resources
				this.food = 100;
				this.ore = 50;
			}

			// Set neural net
			if(creature != null) {
				mainNet = new MainNet(creature.mainNet);
				mainNet.Evolve();

				// Set preferences
				foodValueForLooting *= NeuralNet.logit((float)rand.NextDouble()) + 1;
				oreValueForLooting *= NeuralNet.logit((float)rand.NextDouble()) + 1;

			} else {
				mainNet = new MainNet();
			}

			// Set appearance
			if(creature != null) {
				// Set colour
				bodyR = creature.bodyR;
				bodyG = creature.bodyG;
				bodyB = creature.bodyB;
				int colourIndex = rand.Next() % 6;
                byte colourOffset = Convert.ToByte(rand.Next() % 10);
				switch(colourIndex) {
					case 0:
                        bodyR += colourOffset;
						break;
					case 1:
                        bodyR -= colourOffset;
						break;
					case 2:
                        bodyG += colourOffset;
						break;
					case 3:
                        bodyG -= colourOffset;
						break;
					case 4:
                        bodyB += colourOffset;
						break;
					case 5:
                        bodyB -= colourOffset;
						break;
				}
			} else {
				bodyR = Convert.ToByte(rand.Next() % 256);
				bodyG = Convert.ToByte(rand.Next() % 256);
				bodyB = Convert.ToByte(rand.Next() % 256);
			}
			brush = new SolidBrush(Color.FromArgb(255, bodyR, bodyG, bodyB));
		}

		internal void circleColour(int R, int G, int B) {
			pen.Color = Color.FromArgb(255, R, G, B);
		}

		~Creature() {
			brush.Dispose();
			// Remove itself from residence
			if(this.currentTile != null) {
				this.currentTile.creatureResidentList.Remove(this);
			}
		}

		private static Image farmerImage = Properties.Resources.farmer;

		private static readonly Pen lootLine = new Pen(Color.White, 0.5f);

		internal void Draw(Graphics graphics) {
			// Draw circle
			graphics.DrawEllipse(pen, X - bodySize / 2, Y - bodySize / 2, bodySize, bodySize);
			// Draw bars
			graphics.DrawLine(Pens.LightGreen, X - 3, Y + 2, (6 * food) / Creature.foodForChild - 3 + X, Y + 2);
			graphics.DrawLine(Pens.DarkRed, X - 3, Y + 3, (6 * hp) / maxHp - 3 + X, Y + 3);
			// Draw sprite
			switch(activity) {
				case Activity.FARM:
					graphics.DrawImage(farmerImage, X - 3, Y - 6, 6, 6);
					break;
				case Activity.LOOT:
					graphics.DrawLine(lootLine, X, Y, fightVictim.X, fightVictim.Y);
					break;
				default:
					graphics.FillEllipse(brush, X - bodySize / 2, Y - bodySize / 2, bodySize, bodySize);
					break;
			}
		}

		public Point moveTarget;
		private bool isMoving = false;
		private Point moveRate;
		private Point moveRateExecuted;
		private int moveCycles;
		private int moveExpiry;

		// Move to point moveTarget
		// Calculates rate of X vs Y movement and how many cycles required to reach target. Performes cycles then any remainder movement at end.
		public void move(Map map) {
			// If moving
			if(isMoving) {
				moveExpiry--;
				// Move
				position.X += Math.Sign(moveRateExecuted.X);
				moveRateExecuted.X -= Math.Sign(moveRateExecuted.X);
				position.Y += Math.Sign(moveRateExecuted.Y);
				moveRateExecuted.Y -= Math.Sign(moveRateExecuted.Y);
				// Ensure not off map
				if(position.X < 0) {
					position.X = 0;
					isMoving = false;
					activity = Activity.THINK;
				}
				if(position.X >= map.pixelWidth) {
					position.X = map.pixelWidth - 1;
					isMoving = false;
					activity = Activity.THINK;
				}
				if(position.Y < 0) {
					position.Y = 0;
					isMoving = false;
					activity = Activity.THINK;
				}
				if(position.Y >= map.pixelHeight) {
					position.Y = map.pixelHeight - 1;
					isMoving = false;
					activity = Activity.THINK;
				}
				// If completed cycle
				if(moveRateExecuted.X == 0 && moveRateExecuted.Y == 0) {
					// If more cycles to perform
					if(moveCycles > 0) {
						moveCycles--;
						moveRateExecuted.X = moveRate.X;
						moveRateExecuted.Y = moveRate.Y;
					// Else If we're at the final position
					} else if(moveTarget.Equals(position)) {
						isMoving = false;
						activity = Activity.THINK;
					// Else last cycle was performed, but we have further to move
					} else {
						moveRateExecuted.X = moveTarget.X - position.X;
						moveRateExecuted.Y = moveTarget.Y - position.Y;
					}
				}

			// Else If Not moving & we have a target
			}  else if(!moveTarget.Equals(position)) {
				// Calculate error
				moveRate.Y = moveTarget.Y - position.Y;
				moveRate.X = moveTarget.X - position.X;
				// Normalize direction
				if(Math.Abs(moveRate.Y) > Math.Abs(moveRate.X)) {
					moveCycles = Math.Abs(moveRate.X);
				} else {
					moveCycles = Math.Abs(moveRate.Y);
				}
				if(moveCycles > 0) {
					moveRate.X /= moveCycles;
					moveRate.Y /= moveCycles;
				}
				// Record how much creature should move in each cycle
				moveRateExecuted.X = moveRate.X;
				moveRateExecuted.Y = moveRate.Y;
				// Start moving
				isMoving = true;
				moveExpiry = 20;
			}
			if(moveExpiry <= 0) {
				isMoving = false;
				activity = Activity.THINK;
				// Add creature to tile resident
			}

			if(position.X >= 6000 || position.Y >= 6000) {
				Console.WriteLine("break");
			}
		}

		public enum Activity {
			MOVERANDOM,
			THINK,
			FARM,
			MOVETOFOOD,
			MINE,
			MOVETOORE,
			TRADE,
			MOVETOPROPERTY,
			LOOT
		};

		internal Activity activity;

		// Main update tick routine
		internal void update(Map map) {
			// Age
			if(++creatureAge > creatureAgeMax) {
				request = Request.KILLSELF;

			// Else not dead yet
			} else {

				// Do activity
				switch(activity) {
					case Activity.THINK:
						mainNet.Update(this, map);
						break;
					case Activity.MOVERANDOM:
					case Activity.MOVETOFOOD:
					case Activity.MOVETOORE:
					case Activity.MOVETOPROPERTY:
						move(map);
						break;
					case Activity.FARM:
						farm(map);
						break;
					case Activity.MINE:
						mine(map);
						break;
					case Activity.TRADE:
						activity = Activity.THINK;
						break;
					case Activity.LOOT:
						// We've already looted (see output node in Node.cs)
						// Wait until we can loot again.
						recover();
						break;
				}

				// Eat
				consumeResources();

				// Reproduce
				if(food > foodForChild) {
					request = Request.REPRODUCE;
				}
			}
		}

		internal void buyLand(int tileCost) {
			// If someone else owns it, buy it
			if(currentTile.creatureOwner != null) {
				// Give payment
				ore -= tileCost;
				currentTile.creatureOwner.ore += tileCost;
				// Shred deed
				currentTile.creatureOwner.property = null;

			} else {
				// As soon as a tile is owned, regrowth modifier is x2
				currentTile.tileImprovementFoodregrowthNumerator = Tile.tileImprovementFoodregrowthDenomenator / 2;
			}


			// Put up sign on property
			currentTile.creatureOwner = this;

			// Remove any previous signs
			if(property != null) {
				property.creatureOwner = null;
			}

			// Write deed
			property = currentTile;

			// Update border
			currentTile.UpdateBorder(bodyR, bodyG, bodyB);
		}

		internal int food;
		internal int ore;
		private static readonly int oreConsumption = 1;
		private static readonly int oreConsumptionRate = 5;
		private int oreConsumptionTick = oreConsumptionRate;

		public enum Request {
			NONE,
			KILLSELF,
			REPRODUCE
		}
		internal Request request;
		internal int farmSkill;
		internal int mineSkill;
		internal static readonly int farmWaitTick = 20;
		internal static readonly int oreWaitTick = 20;
		internal static readonly int fightWaitTick = 15;
		internal int farmWait;
		internal int mineWait;
		internal int fightWait;
		internal Creature fightVictim;

		private int farmActionIndex = 0;	// How much the tile has been farmed
		private void farm(Map map) {
			if(++farmActionIndex >= Tile.farmDuration) {
				farmActionIndex -= Tile.farmDuration;
				food += map.getTile(position).farm(this, map.viewLayer);
				farmSkill++;
				activity = Activity.THINK;
			}
		}

		private int miningActionIndex = 0;	// How much the tile has been mined
		private void mine(Map map) {
			if(++miningActionIndex >= Tile.miningDuration) {
				miningActionIndex -= Tile.miningDuration;
				ore += map.getTile(position).mine(this, map.viewLayer);
				mineSkill++;
				activity = Activity.THINK;
			}
		}

		private int recoverActionIndex = 0;	// How long we've recovered after a battle
		private void recover() {
			if(++recoverActionIndex >= (maxHp - hp) * Tile.recoverDuration) {
				recoverActionIndex -= Tile.recoverDuration;
				fightSkill++;
				activity = Activity.THINK;
			}
		}

		// Damage creature
		// @param int damage
		//	damage done to creature
		// @return Loot
		//	resources creature had proportional to how much damage was caused.
		internal struct Loot {
			internal int foodLoot;
			internal int oreLoot;
		}
		internal Loot loot(int damage) {
			int oldHp = hp;
			hp -= damage;
			if(hp <= 0) {
				// Dead
				request = Request.KILLSELF;
				hp = 0;
			}
			Loot loot = new Loot();
			loot.foodLoot = food * (oldHp - hp) / maxHp;
			loot.oreLoot = ore * (oldHp - hp) / maxHp;
			return loot;
		}
	}
}
