using Creational_AbstractFactory2.UIMac;
using Creational_AbstractFactory2.UIWindows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_AbstractFactory2
{
	internal class UserSettingsFormBAD
	{
		//if you want add a new operating system, you have to open many class and add a new OS. 
		//Also you need add a new if condition
		//to resolve this problema you can use a Abstract factory, and the you have a capabilities to create a family of related object based on their interface
		public void Render(OperatingSystemType osType)
		{
			if(osType == OperatingSystemType.Windows)
			{
				new WindowsButtonBAD().Render();
				new WindowsCheckboxBAD().Render();
			}else if(osType == OperatingSystemType.Mac)
			{
				new MacButtonBAD().Render();
				new MacCheckboxBAD().Render();
			}

		}
	}
}
