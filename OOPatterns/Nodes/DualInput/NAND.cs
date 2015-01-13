using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPatterns.Nodes
{
	class NAND : DualInputNode
	{
		// Visitor
		public void Accept(INodeVisitor visitor)
		{
			visitor.Visit(this);
		}

		// Factory
		public override object Clone()
		{
			return new NAND();
		}

		// Decorator
		public override int Work()
		{
			if (_inputA.Equals(1) && _inputB.Equals(1))
				return 0;

			return 1;
		}

	}
}
