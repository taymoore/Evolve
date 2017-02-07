using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolve {
	class Synapse {
		public float strength;
		public Node inputNode;
		public Node outputNode;

        // Synapse strength starts at -1 to +1
        // Gets multiplied by 0 to 2 each mutation
        // 0.1% chance of having synapse reverse polarity

		public Synapse(Node inputNode, Node outputNode, float strength) {
			this.strength = strength;
			this.inputNode = inputNode;
			this.outputNode = outputNode;
		}

		public void Update() {
			outputNode.value += strength * inputNode.value;
		}
	}
}
