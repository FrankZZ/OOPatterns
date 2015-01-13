using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPatterns.Visitors;

namespace OOPatterns.Nodes
{
	public class XOR : DualInputNode
	{
		// Visitor
		public override void Accept(INodeVisitor visitor)
		{
			visitor.Visit(this);
		}

		// Factory
		public override object Clone()
		{
			return new XOR();
		}

		// Decorator
		public override int Work()
		{
			if (!_inputA.Equals(_inputB))
				return 1;

			return 0;
		}

	}
}
