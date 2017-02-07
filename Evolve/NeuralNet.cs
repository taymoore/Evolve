using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolve {
	class NeuralNet {
		protected List<Synapse> synapseList = new List<Synapse>();
		protected static Random rand = new Random();

		internal static readonly int landCost = 2;		// Cost to purchase land

		// Input range of (-5 000 to +5 000) provides output (0 to 1 000)
		static readonly public int sigmoidIntDivisor = int.MaxValue / 5000;
		static public int sigmoid(float input) {
			return Convert.ToInt32(1000 / (1 + (float)Math.Exp(input / -1000)));
		}

		// Input range of (0 to foodMax) provides output (0 to 1)
		static public float sigmoidFoodMax(float input) {
			return 1 / (1 + (float)Math.Exp((input - Tile.foodMax/2) / (Tile.foodMax * -0.1f) ));
		}

		// Input range of (0 to +5 000) provides output (0 to 1)
		static public float sigmoid5000singleEnded(float input) {
			return 1 / (1 + (float)Math.Exp((input - 2500) / -500));
		}

		// Input range of (-5 000 to +5 000) provides output (0 to 1)
		static public float sigmoid5000(float input) {
			return 1 / (1 + (float)Math.Exp(input / -1000));
		}

		// Input range of (0 to +1 000) provides output (0 to 1)
		static public float sigmoid1000singleEnded(float input) {
			return 1 / (1 + (float)Math.Exp((input - 500) / -100));
		}

		// Input range of (-1 000 to +1 000) provides output (0 to 1)
		static public float sigmoid1000(float input) {
			return 1 / (1 + (float)Math.Exp(input / -200));
		}

		// Input range of (0 to +500) provides output (0 to 1)
		static public float sigmoid500singleEnded(float input) {
			return 1 / (1 + (float)Math.Exp((input - 250) / -50));
		}

		// Input range of (min to max) provides output 0 to 1 (specifically 0.0067 to 0.9933)
		static public float sigmoid(float input, int min, int max) {
			return 1 / (1 + (float)Math.Exp((input * 10 - min * 5 - max * 5) / (min - max)));
		}

		// Input range of (-500 to +500) provides output (0 to 1)
		static public float sigmoid500(float input) {
			return 1 / (1 + (float)Math.Exp(input / -100));
		}

		// Input range of (0 to +250) provides output (0 to 1)
		static public float sigmoid250singleEnded(float input) {
			return 1 / (1 + (float)Math.Exp((input - 125) / -25));
		}

		// Input range of (-250 to +250) provides output (0 to 1)
		static public float sigmoid250(float input) {
			return 1 / (1 + (float)Math.Exp(input / -50));
		}

		// Input range of (0 to +100) provides output (0 to 1)
		static public float sigmoid100singleEnded(float input) {
			return 1 / (1 + (float)Math.Exp((input - 50) / -10));
		}

		// Input range of (-100 to +100) provides output (0 to 1)
		static public float sigmoid100(float input) {
			return 1 / (1 + (float)Math.Exp(input / -20));
		}

		// Input range of (0 to +10) provides output (0 to 1)
		static public float sigmoid10singleEnded(float input) {
			return 1 / (1 + (float)Math.Exp((input - 5) / -1));
		}

		// Input range of (-10 to +10) provides output (0 to 1)
		static public float sigmoid10(float input) {
			return 1 / (1 + (float)Math.Exp(input / -2));
		}

		// Input range of (0 to 1) provides output (-1 to 1)
		static public float logit(float input) {
			return (float)Math.Log(input / (1 - input)) / 10;
		}
	}

	class MainNet : NeuralNet {
		internal List<List<Node>> nodeList { get; }
		internal Tile tileWithHighestFood;
		internal Tile tileWithHighestOre;

		public MainNet() {
			//inputNodeList = new List<Node>();
			//outputNodeList = new List<Node>();
			nodeList = new List<List<Node>>();

			// Input nodes
			nodeList.Add(new List<Node>());
			nodeList[0].Add(new InputFoodSelfNode());
			nodeList[0].Add(new InputFoodCentreNode());
			nodeList[0].Add(new InputFoodAreaNode());
			nodeList[0].Add(new InputFoodOnProperty());
			nodeList[0].Add(new InputOreSelfNode());
			nodeList[0].Add(new InputOreCentreNode());
			nodeList[0].Add(new InputOreAreaNode());
			nodeList[0].Add(new InputFoodTradeValue());
			nodeList[0].Add(new InputOreTradeValue());
			nodeList[0].Add(new InputRaidValueNode());			// Value of a raid. Contains RaidNet.
			//nodeList[0].Add(new InputLootNode());

			// Output nodes
			nodeList.Add(new List<Node>());
			nodeList[1].Add(new OutputFarmNode());				// Node 0: Farm
			nodeList[1].Add(new OutputMoveFoodNode());			// Node 1: Move to food
			nodeList[1].Add(new OutputMineNode());				// Node 2: Mine
			nodeList[1].Add(new OutputMoveOreNode());			// Node 3: Move to ore
			nodeList[1].Add(new Node());						// Node 4: Food value
			nodeList[1].Add(new Node());						// Node 5: Ore value
			nodeList[1].Add(new OutputTradeNode());             // Node 6: Trade
			nodeList[1].Add(new Node());						// Node 7: Buy Land
			nodeList[1].Add(new OutputMoveToProperty());		// Node 8: Move to property
			nodeList[1].Add(new OutputRaidNode());				// Node 9: Raid a neighbour

			// Build synapses
			for(int i = 0; i < nodeList.Count - 1; i++) {
				foreach(Node nodeIn in nodeList[i]) {
					foreach(Node nodeOut in nodeList[i + 1]) {
                        // Create synapses with strength between -1 and +1
						synapseList.Add(new Synapse(nodeIn, nodeOut, (float)rand.NextDouble() * 2 - 1f));
					}
				}
			}
		}

		public MainNet(MainNet mainNet) : this() {
			// Copy synapses
			for(int i = 0; i < synapseList.Count; i++) {
				synapseList[i].strength = mainNet.synapseList[i].strength;
			}
		}

		internal void Evolve() {
			foreach(Synapse synapse in synapseList) {
                // Multiply each synapse between 0 and 2
				synapse.strength *= logit((float)rand.NextDouble()) + 1;

                // Give change to have large mutation
                // If random value is less than 0.1%
                if(rand.Next() / (int.MaxValue / 1000) == 0) {
                    synapse.strength *= -1;
                }
			}
		}

		public void Update(Creature creature, Map map) {
			// Update currentTile to speed decision making
			map.getTile(creature);
			if(creature.currentTile == null) {
				throw new System.ArgumentException("Creature could not locate the tile it's standing on.");
			}
			// Consider options
			// Read inputs
			foreach(Node inputNode in nodeList[0]) {
				inputNode.Update(creature, map);
			}
			// Update nodes
			// Erase values
			for(int i = 1; i < nodeList.Count; i++) {
				foreach(Node node in nodeList[i]) {
					node.value = 0;
				}
			}
			// Add each synapse
			foreach(Synapse synapse in synapseList) {
				synapse.Update();
			}
			// Perform action of highest value in output node list
			float maxOutputValue = float.MinValue;
			int maxOutputIndex = 0;
			for(int i = 0; i < nodeList[nodeList.Count - 1].Count; i++) {
				// Passive Actions
				switch(i) {
						case 6: // Trade
							break;
						case 7: // Buy Land
							int tileCost = (creature.currentTile.tileFoodImprovementNumerator + creature.currentTile.tileOreImprovementNumerator);

							if(nodeList[nodeList.Count - 1][i].value > 0 &&			// If value is > 0
							creature.ore > tileCost &&								// And has enough ore to buy land
							!creature.Equals(creature.currentTile.creatureOwner)) {	// And doesn't already own it
								creature.buyLand(tileCost);
							}

							break;
						// Active actions:
						case 0: // Farm
						case 1: // Move to food
						case 2:	// Mine
						case 3: // Move to ore
						case 8: // Move to property
						case 9: // Raid
							if(nodeList[nodeList.Count - 1][i].value > maxOutputValue) {

								bool actionPermissable = true;
								// Reasons to not permit action:
								switch(i) {
									case 0: // Farm
									case 2:	// Mine
										// Creature does not own this tile & it is owned by another creature
										if(creature != creature.currentTile.creatureOwner && creature.currentTile.creatureOwner != null) {
											actionPermissable = false;	// Can't farm/mine on someone else's land
										}
										break;
									case 8:	// Move to property
										// If creature does not own property
										if(creature.property == null) {
											// Cannot move to property if it doesn't own any property
											actionPermissable = false;

										// Else creature owns property
										} else {
											// If creature is standing on its own property
											if(creature.currentTile == creature.property) {
												// Cannot move to property if I'm already standing there
												actionPermissable = false;
											}
										}
										break;
									case 9: // Raid
										// TODO: Ensure not stealing from self
									case 1: // Move to food
									case 3: // Move to ore
										// Always available
										break;
								}

								// Remember action
								if(actionPermissable == true) {
									maxOutputValue = nodeList[nodeList.Count - 1][i].value;
									maxOutputIndex = i;
								}
							}
							break;
						// Not actions:
						case 4: // Food Value
						case 5: // Ore value
							break;
				}
			}
			if(maxOutputValue != float.MinValue) {
				// Do activity
				nodeList[nodeList.Count - 1][maxOutputIndex].Update(creature, map);
			} else {
				// Nothing was preferred
				// do something random
				nodeList[nodeList.Count - 1][rand.Next() % nodeList[nodeList.Count - 1].Count].Update(creature, map);
			}
		}
	}

    class RaidNet : NeuralNet {
		internal List<List<Node>> nodeList { get; }
        internal struct VictimList {
            internal Creature victim;
            internal float value;
        }

        internal RaidNet() {
			nodeList = new List<List<Node>>();

			// Input nodes
			nodeList.Add(new List<Node>());
			nodeList[0].Add(new InputRaidGeneticDisparity());
			nodeList[0].Add(new InputFoodSelfNode());
			nodeList[0].Add(new InputOreSelfNode());

            // Output node
			nodeList.Add(new List<Node>());
			nodeList[1].Add(new Node());        // Node 0: Value of target to raid

			// Build synapses
			for(int i = 0; i < nodeList.Count - 1; i++) {
				foreach(Node nodeIn in nodeList[i]) {
					foreach(Node nodeOut in nodeList[i + 1]) {
                        // Create synapses with strength between -1 and +1
						synapseList.Add(new Synapse(nodeIn, nodeOut, (float)rand.NextDouble() * 2 - 1f));
					}
				}
			}
        }

        internal VictimList Update(Creature selfCreature, Creature otherCreature, Map map) {
            // Update input nodes
            nodeList[0][0].JudgeCreature(selfCreature, otherCreature);
            nodeList[0][1].Update(otherCreature, map);
            nodeList[0][2].Update(otherCreature, map);

			// Update output nodes nodes
			// Erase values
			for(int i = 1; i < nodeList.Count; i++) {
				foreach(Node node in nodeList[i]) {
					node.value = 0;
				}
			}
			// Add each synapse
			foreach(Synapse synapse in synapseList) {
				synapse.Update();
			}
            // Add creature to victim list
            VictimList victim = new VictimList();
            victim.victim = otherCreature;
            victim.value = nodeList[1][0].value;
			return victim;
        }
    }
}
