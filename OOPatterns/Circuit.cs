using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
			Console.WriteLine("Initializing simulation of the circuit...");
			
			// Get all input nodes
			InputNodeVisitor inputVisitor = new InputNodeVisitor();
			List<Node> inputNodeList = inputVisitor.VisitAll(_circuit);
			
			Console.WriteLine("Simulating the circuit...");
			
			// Make them Work()
			foreach (Node node in inputNodeList)
				node.PushValue();

			Console.WriteLine("Circuit simulation ended.");
		}

		// Get a node from the circuit by Id
		public Node GetNode(string Id)
		{
			return _circuit.Where(node => node.Id == Id).First();
		}

		public static void Parse(string filePath)
		{
			Circuit circuit = new Circuit();
			bool processingNodes = true;

			using (StreamReader sr = new StreamReader(filePath))
			{
				string line;
				char[] nodeSplitters = {':', ';'};
				char[] edgeSplitters = { ':', ',', ';' };
				string[] splittedValues;

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
						processingNodes = false;
						continue;
					}

					// Skip commented line for further processing
					if (line.StartsWith("#"))
						continue;
						
					if (processingNodes == true) // We are processing nodes
					{
						splittedValues = line.Split(nodeSplitters, StringSplitOptions.RemoveEmptyEntries);
						// TODO: Add to circuit
					}
					else // We are processing edges
					{
						splittedValues = line.Split(edgeSplitters, StringSplitOptions.RemoveEmptyEntries);
						
						// Connect the current node to the nodes on its edges
						Node currentNode = circuit.GetNode(splittedValues[0]);
						for (int i = 1; i < splittedValues.Length; i++)
						{
							Node otherNode = circuit.GetNode(splittedValues[i]);
							
							currentNode.Connect(otherNode);
						}
					}
				}
			}	
		}
	}
}
