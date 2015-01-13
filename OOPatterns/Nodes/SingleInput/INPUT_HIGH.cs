using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPatterns.Visitors;

namespace OOPatterns.Nodes
{
	public class INPUT_HIGH : SingleInputNode
	{
		// Visitor
		public override void Accept(INodeVisitor visitor)
		{
			visitor.Visit(this);
		}

		// Factory
		public override object Clone()
		{
			return new INPUT_HIGH();
		}

		// Decorator
		public override int Work()
		{
			return 1;
		}

	}
}
