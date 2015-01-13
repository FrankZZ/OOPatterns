using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPatterns.Visitors;

namespace OOPatterns.Nodes
{
	public abstract class Node
	{
		public List<Node> _connections = new List<Node>();

		protected string _key;

		// Visitor 
		public abstract void Accept(INodeVisitor visitor);

		// Return the switch type, eg. XOR
		public String Key
		{
			get {
				return this.GetType().Name;
			}
		}

		// Factory
		public abstract object Clone();

		// Identifier of the switch
		public string Id
		{
			get;
			set;
		}

		protected abstract void setValue(int value);

		public void Connect(Node node)
		{
			this._connections.Add(node);
			Console.WriteLine("[" + this.Id + "] CONNECTED TO [" + node.Id + "].");
		}

		
		// Decorator
		// Performs the calculation needed for this switch, returns the result
		public abstract int Work();
		public void PushValue()
		{
			foreach (Node node in this._connections)
			{
				node.setValue(Work());
			}
		}
	}
}
