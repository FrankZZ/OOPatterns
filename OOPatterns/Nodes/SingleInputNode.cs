﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPatterns.Nodes
{
	public abstract class SingleInputNode : Node
	{
		protected int _inputA;

		protected override void setValue(int value)
		{
			Console.WriteLine("[" + this.GetPaddedId() + "] SET VALUE A TO: " + value + ".");
			_inputA = value;
			PushValue();
		}
	}
}
