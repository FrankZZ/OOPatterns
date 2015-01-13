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
			/*
			Console.WriteLine("Please input the path to a circuit file to load...");
			string filePath = Console.ReadLine();

			using (StreamReader sr = new StreamReader(filePath))
			{
				string line;
				while ((line = sr.ReadLine()) != null)
				{

				}
			}
			*/

			NOT xor = new NOT();

			Console.WriteLine(xor.Key);
			Console.ReadKey();
		}
	}
}
