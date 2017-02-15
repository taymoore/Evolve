using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Node input range should be between +- 500

namespace Evolve {
	class Node {
		public float value;
		protected static Random rand = new Random();
		internal virtual void Update(Creature creature, Map map) {
		}
        internal virtual void JudgeCreature(Creature selfCreature, Creature otherCreature) {
        }
	}

	class InputFoodTradeValue : Node {
		internal override void Update(Creature creature, Map map) {
			// Get market price of food
			// Since we only ever buy, take the difference between selling and buying price
			float profit = 0;
			value = 0;
			foreach(Creature creatureResident in creature.currentTile.creatureResidentList) {
				profit = creature.mainNet.nodeList[creature.mainNet.nodeList.Count - 1][4].value - creatureResident.mainNet.nodeList[creature.mainNet.nodeList.Count - 1][4].value;
				if(profit > value) {
					value = profit;
				}
			}
			if(creature.Equals(map.selectedCreature) && value > 0) {
				Console.WriteLine("Profit: {0}", value);
			}
			value = NeuralNet.sigmoid(value) - 500;
			//value = creature.mainNet.nodeList[creature.mainNet.nodeList.Count - 1][4].value;	// Default buy value is our own sell value
			//foreach(Creature creatureResident in creature.currentTile.creatureResidentList) {
			//	if(creatureResident.mainNet.nodeList[creature.mainNet.nodeList.Count - 1][4].value < value) {
			//		value = creatureResident.mainNet.nodeList[creature.mainNet.nodeList.Count - 1][4].value;
			//	}
			//}
		}
	}

	class InputOreTradeValue : Node {
		internal override void Update(Creature creature, Map map) {
			// Get market price of ore
			float profit = 0;
			value = 0;
			foreach(Creature creatureResident in creature.currentTile.creatureResidentList) {
				profit = creature.mainNet.nodeList[creature.mainNet.nodeList.Count - 1][5].value - creatureResident.mainNet.nodeList[creature.mainNet.nodeList.Count - 1][5].value;
				if(profit > value) {
					value = profit;
				}
			}
			value = NeuralNet.sigmoid(value) - 500;
		}
	}

	class InputFoodSelfNode : Node {
		internal override void Update(Creature creature, Map map) {
			// Look at it's own food
			value = NeuralNet.sigmoid100singleEnded(creature.food);
		}
	}

	class InputOreSelfNode : Node {
		internal override void Update(Creature creature, Map map) {
			// Look at it's own ore
			value = NeuralNet.sigmoid(creature.ore, 0, creature.property != null ? // Max sigmoid value = cost to improve a tile
														(creature.property.tileFoodImprovementNumerator + creature.property.tileOreImprovementNumerator) * 5 :
														10);	// If creature does not own a tile, default value is cost to improve a tile at level 1
			if(value == float.NaN) {
				throw new Exception();
			}
		}
	}

	class InputFoodOnProperty: Node {
		internal override void Update(Creature creature, Map map) {
			// Look at food on it's purchased property
			if(creature.property != null) {
				value = (float)creature.property.food / Tile.foodMax;
			} else {
				value = 0;
			}
		}
	}

	class InputOreAreaNode : Node {
		internal override void Update(Creature creature, Map map) {
			value = int.MinValue;
			creature.mainNet.tileWithHighestOre = map.getTile(creature);
			// Get maximum value of ore around creature
			Tile tile;
			tile = map.getTile(creature.currentTile.tileX, creature.currentTile.tileY - 1);
			if(tile != null) {
				if(value < tile.ore) {
					value = tile.ore;
					creature.mainNet.tileWithHighestOre = tile;
				}
			}
			tile = map.getTile(creature.currentTile.tileX, creature.currentTile.tileY + 1);
			if(tile != null) {
				if(value < tile.ore) {
					value = tile.ore;
					creature.mainNet.tileWithHighestOre = tile;
				}
			}
			tile = map.getTile(creature.currentTile.tileX - 1, creature.currentTile.tileY);
			if(tile != null) {
				if(value < tile.ore) {
					value = tile.ore;
					creature.mainNet.tileWithHighestOre = tile;
				}
			}
			tile = map.getTile(creature.currentTile.tileX + 1, creature.currentTile.tileY);
			if(tile != null) {
				if(value < tile.ore) {
					value = tile.ore;
					creature.mainNet.tileWithHighestOre = tile;
				}
			}
			// Bound between 0 and 1
			value /= Tile.foodMax;
		}
	}

	class InputFoodAreaNode : Node {
		internal override void Update(Creature creature, Map map) {
			value = int.MinValue;
			creature.mainNet.tileWithHighestFood = map.getTile(creature);
			// Get maximum value of food around creature
			Tile tile;
			tile = map.getTile(creature.currentTile.tileX, creature.currentTile.tileY - 1);
			if(tile != null) {
				if(value < tile.food) {
					value = tile.food;
					creature.mainNet.tileWithHighestFood = tile;
				}
			}
			tile = map.getTile(creature.currentTile.tileX, creature.currentTile.tileY + 1);
			if(tile != null) {
				if(value < tile.food) {
					value = tile.food;
					creature.mainNet.tileWithHighestFood = tile;
				}
			}
			tile = map.getTile(creature.currentTile.tileX - 1, creature.currentTile.tileY);
			if(tile != null) {
				if(value < tile.food) {
					value = tile.food;
					creature.mainNet.tileWithHighestFood = tile;
				}
			}
			tile = map.getTile(creature.currentTile.tileX + 1, creature.currentTile.tileY);
			if(tile != null) {
				if(value < tile.food) {
					value = tile.food;
					creature.mainNet.tileWithHighestFood = tile;
				}
			}
			// Bound between 0 and 1
			value /= Tile.foodMax;
		}
	}

	class InputFoodCentreNode : Node {
		internal override void Update(Creature creature, Map map) {
			// Look at food under creature
			value = creature.currentTile.food;
			// Bound between 0 and 1
			value /= Tile.foodMax;
		}
	}

	class InputOreCentreNode : Node {
		internal override void Update(Creature creature, Map map) {
			// Look at ore under creature
			value = creature.currentTile.ore;
			// Bound between 0 and 1
			value /= Tile.foodMax;
		}
	}

	class InputLootNode : Node {
		internal override void Update(Creature creature, Map map) {
			value = float.MinValue;
			creature.fightVictim = null;
			// Consider creatures to loot
			foreach(Creature prey in creature.currentTile.creatureResidentList) {
				if(prey.food * creature.foodValueForLooting + prey.ore * creature.oreValueForLooting > value) {
					// How jucy the prey is
					value = prey.food * creature.foodValueForLooting + prey.ore * creature.oreValueForLooting;
					// Remember prey for later ;)
					creature.fightVictim = prey;
				}
			}
			if(value == float.MinValue) {
				value = 0;
			}
			// Bound between 0 and 1
			value = NeuralNet.sigmoid500singleEnded(value);
		}
	}

	/* Output Actions: */

	class OutputFarmNode : Node {
		internal override void Update(Creature creature, Map map) {
			// Farm
			creature.activity = Creature.Activity.FARM;
			// Change creature colour
			creature.circleColour(0, 255, 0);
			// Add creature to tile resident
			if(!creature.currentTile.creatureResidentList.Contains(creature)) {
				creature.currentTile.creatureResidentList.Add(creature);
			}
		}
	}

	class OutputMineNode : Node {
		internal override void Update(Creature creature, Map map) {
			// Farm
			creature.activity = Creature.Activity.MINE;
			// Change creature colour
			creature.circleColour(255, 0, 0);
			// Add creature to tile resident
			if(!creature.currentTile.creatureResidentList.Contains(creature)) {
				creature.currentTile.creatureResidentList.Add(creature);
			}
		}
	}

	class OutputMoveFoodNode : Node {
		internal override void Update(Creature creature, Map map) {
			// Remove creature from tile resident
			creature.currentTile.creatureResidentList.Remove(creature);
			// Move to highest food
			creature.moveTarget.X = creature.mainNet.tileWithHighestFood.pixelX + rand.Next() % Tile.tileSize;
			creature.moveTarget.Y = creature.mainNet.tileWithHighestFood.pixelY + rand.Next() % Tile.tileSize;
			creature.activity = Creature.Activity.MOVETOFOOD;
			creature.circleColour(255, 255, 255);
		}
	}

	class OutputMoveOreNode : Node {
		internal override void Update(Creature creature, Map map) {
			// Remove creature from tile resident
			creature.currentTile.creatureResidentList.Remove(creature);
			// Move to highest ore
			creature.moveTarget.X = creature.mainNet.tileWithHighestOre.pixelX + rand.Next() % Tile.tileSize;
			creature.moveTarget.Y = creature.mainNet.tileWithHighestOre.pixelY + rand.Next() % Tile.tileSize;
			creature.activity = Creature.Activity.MOVETOORE;
			creature.circleColour(255, 255, 255);
		}
	}

	class OutputTradeNode : Node {
		internal override void Update(Creature creature, Map map) {
			// Find creature with lowest selling value
			float ourItemValue;																			// Amount we value item
			float theirItemValue;																			// Amount they value item
			float buyValue;																				// Amount we want the trade
			float sellValue;																				// Amount trading partner wants the trade
			Creature tradingPartner;                                                                    // Trading Partner

			// Look for a trading partner for food
			tradingPartner = null;
			buyValue = 0;
			sellValue = 0;
			ourItemValue = creature.mainNet.nodeList[creature.mainNet.nodeList.Count - 1][4].value;
			foreach(Creature potentialTradingPartner in creature.currentTile.creatureResidentList) {
				// If other creature will sell for less than we value item
				theirItemValue = potentialTradingPartner.mainNet.nodeList[potentialTradingPartner.mainNet.nodeList.Count - 1][4].value;
				if(ourItemValue - theirItemValue > buyValue) {
					// Remember this potential trade
					buyValue = ourItemValue - theirItemValue;
					tradingPartner = potentialTradingPartner;
				}
			}
			// If we found a trading partner
			if(tradingPartner != null) {
				// If partner has items to sell
				if(tradingPartner.food > 100) {
					// Find something that partner will buy
					theirItemValue = tradingPartner.mainNet.nodeList[tradingPartner.mainNet.nodeList.Count - 1][5].value;
					ourItemValue = creature.mainNet.nodeList[creature.mainNet.nodeList.Count - 1][5].value;
					if(theirItemValue - ourItemValue > sellValue) {
						sellValue = theirItemValue - ourItemValue;
					}
					// If they're willing to trade and we have enough resources to trade
					if(sellValue > 0 && creature.ore > 100) {
						// Mark trading partner
						creature.circleColour(255, 255, 0);
						tradingPartner.circleColour(255, 255, 0);
						// Trade at ratio of preferences
						if(buyValue > sellValue) {
							// We value the trade more, so we give more to make the trade happen
							buyValue /= sellValue;
							buyValue = (MainNet.sigmoid(buyValue) - 500) / 50;
							// Give buyValue for every 1 purchase
							tradingPartner.ore += (int)buyValue;
							creature.ore -= (int)buyValue;
							tradingPartner.food -= 1;
							creature.food += 1;
						} else {
							// They value the trade more, so we take more to make the trade happen
							sellValue /= buyValue;
							sellValue = (MainNet.sigmoid(sellValue) - 500) / 50;
							// Buy sellValue for every 1 sold
							tradingPartner.ore += 1;
							creature.ore -= 1;
							tradingPartner.food -= (int)sellValue;
							creature.food += (int)sellValue;
						}
					}
				}
			}

			// Look for a trading partner for ore 
			tradingPartner = null;
			buyValue = 0;
			sellValue = 0;
			ourItemValue = creature.mainNet.nodeList[creature.mainNet.nodeList.Count - 1][5].value;
			foreach(Creature potentialTradingPartner in creature.currentTile.creatureResidentList) {
				// If other creature will sell for less than we value item
				theirItemValue = potentialTradingPartner.mainNet.nodeList[potentialTradingPartner.mainNet.nodeList.Count - 1][5].value;
				if(ourItemValue - theirItemValue > buyValue) {
					// Remember this potential trade
					buyValue = ourItemValue - theirItemValue;
					tradingPartner = potentialTradingPartner;
				}
			}
			// If we found a trading partner
			if(tradingPartner != null) {
				// If partner has items to sell
				if(tradingPartner.ore > 100) {
					// Find something that partner will buy
					theirItemValue = tradingPartner.mainNet.nodeList[tradingPartner.mainNet.nodeList.Count - 1][4].value;
					ourItemValue = creature.mainNet.nodeList[creature.mainNet.nodeList.Count - 1][4].value;
					if(theirItemValue - ourItemValue > sellValue) {
						sellValue = theirItemValue - ourItemValue;
					}
					// If they're willing to trade and we have enough resources to trade
					if(sellValue > 0 && creature.food > 100) {
						// Mark trading partner
						creature.circleColour(255, 255, 0);
						tradingPartner.circleColour(255, 255, 0);
						// Trade at ratio of preferences
						if(buyValue > sellValue) {
							// We value the trade more, so we give more to make the trade happen
							buyValue /= sellValue;
							buyValue = (MainNet.sigmoid(buyValue) - 500) / 10;
							// Give buyValue for every 1 purchase
							tradingPartner.food += (int)buyValue;
							creature.food -= (int)buyValue;
							tradingPartner.ore -= 1;
							creature.ore += 1;
						} else {
							// They value the trade more, so we take more to make the trade happen
							sellValue /= buyValue;
							sellValue = (MainNet.sigmoid(sellValue) - 500) / 10;
							// Buy sellValue for every 1 sold
							tradingPartner.food += 1;
							creature.food -= 1;
							tradingPartner.ore -= (int)sellValue;
							creature.ore += (int)sellValue;
						}
					}
				}
			}

			// Add creature to tile resident
			if(!creature.currentTile.creatureResidentList.Contains(creature)) {
				creature.currentTile.creatureResidentList.Add(creature);
			}

			creature.activity = Creature.Activity.TRADE;
		}
	}

	class OutputRaidNode : Node {
		internal override void Update(Creature creature, Map map) {
			// Add creature to tile resident
			if(!creature.currentTile.creatureResidentList.Contains(creature)) {
				creature.currentTile.creatureResidentList.Add(creature);
			}
			// Steal from any random creature
			creature.fightVictim = creature.currentTile.creatureResidentList[rand.Next() % creature.currentTile.creatureResidentList.Count];
			// Ensure I'm not stealing from myself
			if(!creature.fightVictim.Equals(creature)) {
				// Create a loot sack
				Creature.Loot loot;
				// Damage creature
				loot = creature.fightVictim.loot(creature.fightSkill / 10);
				// Enjoy the spoils of war
				creature.food += loot.foodLoot;
				creature.ore += loot.oreLoot;
				// Change creature colour
				creature.circleColour(0, 0, 255);
				// Set activity
				creature.activity = Creature.Activity.LOOT;
			}
		}
	}

	class OutputMoveToProperty : Node {
		internal override void Update(Creature creature, Map map) {
			// Remove creature from tile resident
			creature.currentTile.creatureResidentList.Remove(creature);
			// Move to property
			creature.moveTarget.X = creature.property.pixelX + rand.Next() % Tile.tileSize;
			creature.moveTarget.Y = creature.property.pixelY + rand.Next() % Tile.tileSize;
			creature.activity = Creature.Activity.MOVETOPROPERTY;
			creature.circleColour(255, 255, 255);
		}
	}

    // Value of raiding creatures in vincinity
    class InputRaidValueNode : Node {
        internal RaidNet raidNet = new RaidNet();
        internal List<RaidNet.VictimList> victimList = new List<RaidNet.VictimList>();

		internal override void Update(Creature creature, Map map) {
            bool creatureHasBeenJudged = false;
            int index = 0;
            // Look for a creature to judge on current tile
            creatureHasBeenJudged = judgePotentialVictimFromList(creature, creature.currentTile.creatureResidentList, map);
            if(creatureHasBeenJudged == false) {
                // Look for creature around current tile
            }
            do {
                
            } while(creatureHasBeenJudged == false && )
		}

        // Judges any creatures in the potentialVictimList
        // Returns if a creatures has been judged
        private bool judgePotentialVictimFromList(Creature selfCreature, List<Creature> potentialVictimList, Map map) {
			foreach(Creature potentialVictim in potentialVictimList) {
				// If not myself
				if(!potentialVictim.Equals(selfCreature)) {
                    // Search through list to determine if potential victim has already been judged
                    bool potentialVictimHasBeenJudged = false;
                    foreach(RaidNet.VictimList victimListVictim in victimList) {
                        if(victimListVictim.victim.Equals(potentialVictim)) {
                            potentialVictimHasBeenJudged = true;
                            break;
                        }
                    }
                    // If victim has not been judged
                    if(potentialVictimHasBeenJudged == false) {
                        // Judge victim
                        raidNet.Update(selfCreature, potentialVictim, map);
                        return true;
                    }
				}
			}
            return false;
        }
	}

    // Raid Nodes
    // Input Nodes
    class InputRaidGeneticDisparity : Node {
        internal override void JudgeCreature(Creature selfCreature, Creature otherCreature) {
            // Calculate genetic disparity between self and vicitm
            value = Math.Abs(otherCreature.bodyR - selfCreature.bodyR);
            value += Math.Abs(otherCreature.bodyG - selfCreature.bodyG);
            value += Math.Abs(otherCreature.bodyB - selfCreature.bodyB);
            // Bound
            value = NeuralNet.sigmoid(value, 0, 3 * 255);
        }
    }
}
