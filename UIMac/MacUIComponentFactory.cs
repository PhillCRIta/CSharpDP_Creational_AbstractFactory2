using Creational_AbstractFactory2.UIMac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_AbstractFactory2
{
	internal class MacUIComponentFactory : IUIComponentFactory
	{
		public IButton CreateButton()
		{
			return new MacButton();
		}

		public ICheckbox CreateCheckbox()
		{
			return new MacCheckbox();
		}
	}
}
