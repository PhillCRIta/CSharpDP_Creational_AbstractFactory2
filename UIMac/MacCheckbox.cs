﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_AbstractFactory2.UIMac
{
	internal class MacCheckbox : ICheckbox
	{
		public void Render()
		{
			Console.WriteLine("Im' rendering CHECKBOX on Mac");
		}
	}
}