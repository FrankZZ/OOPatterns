using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using OOPatterns.Nodes;

namespace OOPatterns.Factory
{
	class NodeFactory
	{
		Dictionary<string, Type> _typeDictionary = new Dictionary<string, Type>();

		// Get and filter all types within the given namespace
		private void _initialize(Assembly assembly, string nameSpace)
		{
			
		}

		public NodeFactory()
		{
			Type[] NodeTypes = Assembly.GetExecutingAssembly().GetTypes()
				.Where(t => String.Equals(t.Namespace, "OOPatterns.Nodes", StringComparison.Ordinal))
				.ToArray();
			foreach (Type type in NodeTypes)
			{
				_typeDictionary.Add(type.Name, type);
			}
		}

		public Node Create(string Type, string Id)
		{
			Node node = (Node)Activator.CreateInstance(_typeDictionary[Type]);
			node.Id = Id;
			return node;
		}

	}
}
