using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPatterns.Visitors;

namespace OOPatterns.Nodes
{
	public class NOT : SingleInputNode
	{
		// Visitor
		public override void Accept(INodeVisitor visitor)
		{
			visitor.Visit(this);
		}

		// Factory
		public override object Clone()
		{
			return new NOT();
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
