using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPatterns.Nodes;

namespace OOPatterns.Visitors
{
	public interface INodeVisitor
	{
		void Visit(AND obj);
		void Visit(NAND obj);
		void Visit(NOR obj);
		void Visit(OR obj);
		void Visit(XOR obj);
		void Visit(INPUT_HIGH obj);
		void Visit(INPUT_LOW obj);
		void Visit(NOT obj);

		void Visit(PROBE obj);
	}
}
