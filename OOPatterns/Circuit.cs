using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPatterns.Factory;
using OOPatterns.Nodes;
using OOPatterns.Visitors;

namespace OOPatterns
{
	class Circuit
	{
		private List<Node> _circuit = new List<Node>();
		
		public void Add(Node node)
		{
			_circuit.Add(node);
		}

		public void Start()
		{
			Console.WriteLine("Initializing simulation of the circuit...\r\n");
			
			// Get all input nodes
			InputNodeVisitor inputVisitor = new InputNodeVisitor();
			List<Node> inputNodeList = inputVisitor.VisitAll(_circuit);
			
			Console.WriteLine("Simulating the circuit...\r\n");
			
			// Make them Work()
			foreach (Node node in inputNodeList)
				node.PushValue();

			Console.WriteLine("Printing all probes...\r\n");
			
			OutputNodeVisitor outputVisitor = new OutputNodeVisitor();
			List<Node> outputNodeList = outputVisitor.VisitAll(_circuit);

			foreach (Node node in outputNodeList)
				Console.WriteLine("[" + node.GetPaddedId() + "] VALUE: " + node.Work());

			Console.WriteLine("Circuit simulation ended, bye.\r\n");
		}

		// Get a node from the circuit by Id
		public Node GetNode(string Id)
		{
			return _circuit.Where(node => node.Id == Id).First();
		}

		public static Circuit Parse(string filePath)
		{
			Circuit circuit = new Circuit();
			bool processingNodes = true;
			Console.WriteLine("Opening circuit file...\r\n");

			using (StreamReader sr = new StreamReader(filePath))
			{
				string line;
				char[] nodeSplitters = {':', ';'};
				char[] edgeSplitters = { ':', ',', ';' };
				string[] splittedValues;
				NodeFactory factory = new NodeFactory();
				Console.WriteLine("Starting to read circuit file...\r\n");
				Console.WriteLine("Initializing nodes...\r\n");
				while ((line = sr.ReadLine()) != null)
				{
					// Remove unnecessary characters from the line
					line = line.Replace("\t", "").Trim();

					// Skip empty line
					if (line.Length == 0)
						continue;

					// Check for comment that ends with edges
					if (line.EndsWith("edges"))
					{
						Console.WriteLine("Connecting nodes with their edge neighbours...\r\n");
						processingNodes = false;
						continue;
					}

					// Skip commented line for further processing
					if (line.StartsWith("#"))
						continue;
						
					if (processingNodes == true) // We are processing nodes
					{
						splittedValues = line.Split(nodeSplitters, StringSplitOptions.RemoveEmptyEntries);
						string currentNodeType = splittedValues[1].Trim();
						string currentNodeId = splittedValues[0].Trim();

						circuit.Add(factory.Create(currentNodeType, currentNodeId));
					}
					else // We are processing edges
					{
						splittedValues = line.Split(edgeSplitters, StringSplitOptions.RemoveEmptyEntries);
						
						// Connect the current node to the nodes on its edges
						Node currentNode = circuit.GetNode(splittedValues[0].Trim());
						for (int i = 1; i < splittedValues.Length; i++)
						{
							Node otherNode = circuit.GetNode(splittedValues[i].Trim());
							
							currentNode.Connect(otherNode);
						}
					}
				}
			}
			return circuit;	
		}
	}
}
