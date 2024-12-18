using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_AbstractFactory2.UIWindows
{
	internal class WindowsUIComponentFactory : IUIComponentFactory
	{
		public IButton CreateButton()
		{
			return new WindowsButton();
		}

		public ICheckbox CreateCheckbox()
		{
			return new WindowsCheckbox();
		}
	}
}
