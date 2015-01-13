using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPatterns.Nodes
{
	class Probe : SingleInputNode
	{
		// Visitor
		public void Accept(INodeVisitor visitor)
		{
			visitor.Visit(this);
		}

		// Factory
		public override object Clone()
		{
			return new Probe();
		}

		// Decorator
		public override int Work()
		{
			return _inputA;
		}

	}
}
