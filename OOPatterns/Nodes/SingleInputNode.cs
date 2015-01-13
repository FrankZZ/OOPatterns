using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPatterns.Nodes
{
	abstract class SingleInputNode : Node
	{
		protected int _inputA;

		protected override void setValue(int value)
		{
			Console.WriteLine("[" + this.Id + "] SET VALUE [A] TO [" + value + "].");
			_inputA = value;
			PushValue();
		}
	}
}
