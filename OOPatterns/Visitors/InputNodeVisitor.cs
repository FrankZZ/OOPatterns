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
		// INPUT_HIGH node must be added to List
		public override void Visit(INPUT_HIGH obj)
		{
			Add(obj);
		}

		// INPUT_LOW node must be added to List
		public override void Visit(INPUT_LOW obj)
		{
			Add(obj);
		}
	}
}
