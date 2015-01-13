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
		private string _id;
		public string Id
		{
			get
			{
				return _id;
			}
			set
			{
				_id = value;
				Console.WriteLine("[" + this.GetPaddedId() + "] INITIALIZED.");
			}
		}

		public string GetPaddedId()
		{
			string Id = this.Id;
			int length = 6 - this.Id.Length;

			for (int i = 0; i < length; i++)
				Id += " ";

			return Id;
		}

		protected abstract void setValue(int value);

		public void Connect(Node node)
		{
			this._connections.Add(node);
			Console.WriteLine("[" + this.GetPaddedId() + "] CONNECTED TO [" + node.GetPaddedId() + "].");
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
