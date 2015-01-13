﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPatterns.Nodes;

namespace OOPatterns.Visitors
{
	class OutputNodeVisitor : NodeVisitor
	{
		// Probe node found, must be added to list
		public override void Visit(Probe obj)
		{
			Add(obj);
		}
	}
}
