using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_AbstractFactory2.UIMac
{
	internal class MacCheckboxBAD : ICheckboxBAD
	{
		public void Render()
		{
			Console.WriteLine("Im' rendering CHECKBOX on Mac");
		}
	}
}
