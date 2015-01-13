using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPatterns.Nodes
{
	class Low : SingleInputNode
	{
		// Visitor
		public void Accept(INodeVisitor visitor)
		{
			visitor.Visit(this);
		}

		// Factory
		public override object Clone()
		{
			return new Low();
		}

		// Decorator
		public override int Work()
		{
			if (_inputA.Equals(0))
				return 1;

			return 0;
		}

	}
}
