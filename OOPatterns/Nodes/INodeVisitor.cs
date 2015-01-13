using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPatterns.Nodes
{
	interface INodeVisitor
	{
		void Visit(AND obj);
		void Visit(NAND obj);
		void Visit(NOR obj);
		void Visit(OR obj);
		void Visit(XOR obj);
		void Visit(High obj);
		void Visit(Low obj);
		void Visit(NOT obj);

		void Visit(Probe obj);
	}
}
