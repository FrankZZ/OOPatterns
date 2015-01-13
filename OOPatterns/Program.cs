using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPatterns.Nodes;

namespace OOPatterns
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine("Please input the path to a circuit file to load...");
				string filePath = Console.ReadLine();

				Circuit circuit = Circuit.Parse(filePath);
			
				circuit.Start();
			}
		}
	}
}
