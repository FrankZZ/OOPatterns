using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPatterns.Nodes
{
	abstract class DualInputNode : Node
	{
		// input 1
		protected int _inputA;

		// input 2
		protected int _inputB;

		protected override void setValue(int value)
		{
			if (_inputA == -1)
			{
				Console.WriteLine("[" + this.Id + "] SET VALUE [A] TO [" + value + "].");
				_inputA = value;
			}
			else
			{
				Console.WriteLine("[" + this.Id + "] SET VALUE [B] TO [" + value + "].");
				_inputB = value;
			}

			PushValue();
		}
	}
}
