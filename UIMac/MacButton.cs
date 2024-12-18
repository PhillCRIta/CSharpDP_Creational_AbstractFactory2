﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_AbstractFactory2.UIMac
{
	internal class MacButton : IButton
	{
		public void Render()
		{
			Console.WriteLine("I'm rendering BUTTON on Mac");
		}
	}
}
