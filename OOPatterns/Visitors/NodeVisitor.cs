using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPatterns.Nodes;

namespace OOPatterns.Visitors
{
	abstract class NodeVisitor : INodeVisitor
	{
		private List<Node> _nodes = new List<Node>();
		
		public List<Node> VisitAll(List<Node> Nodes)
		{
			foreach (Node node in Nodes)
				node.Accept(this);

			return _nodes;
		}

		protected void Add(Node obj)
		{
			_nodes.Add(obj);
		}

		public virtual void Visit(PROBE obj)
		{
			
		}
		public virtual void Visit(INPUT_HIGH obj)
		{
			
		}

		public virtual void Visit(INPUT_LOW obj)
		{
			
		}

		public virtual void Visit(AND obj)
		{
			
		}

		public virtual void Visit(NAND obj)
		{
			
		}

		public virtual void Visit(NOR obj)
		{
			
		}

		public virtual void Visit(OR obj)
		{
			
		}

		public virtual void Visit(XOR obj)
		{
			
		}

		public virtual void Visit(NOT obj)
		{
			
		}
	}
}
