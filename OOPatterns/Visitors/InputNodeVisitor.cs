using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPatterns.Nodes;

namespace OOPatterns.Visitors
{
	class InputNodeVisitor : NodeVisitor
	{
		// High node must be added to List
		public override void Visit(High obj)
		{
			Add(obj);
		}

		// Low node must be added to List
		public override void Visit(Low obj)
		{
			Add(obj);
		}
	}
}
