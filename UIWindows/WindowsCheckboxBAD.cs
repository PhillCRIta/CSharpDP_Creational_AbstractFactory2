﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_AbstractFactory2.UIWindows
{
	internal class WindowsCheckboxBAD : ICheckboxBAD
	{
		public void Render()
		{
			Console.WriteLine("I'm rendering CHECKBOX Windows");
		}
	}
}