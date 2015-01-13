using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPatterns.Nodes
{
	class AND : DualInputNode
	{
		// Visitor
		public void Accept(INodeVisitor visitor)
		{
			visitor.Visit(this);
		}

		// Factory
		public override object Clone()
		{
			return new AND();
		}

		// Decorator
		public override int Work()
		{
			if (_inputA.Equals(1) && _inputB.Equals(1))
				return 1;

			return 0;
		}

	}
}
