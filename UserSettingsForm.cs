using Creational_AbstractFactory2.UIMac;
using Creational_AbstractFactory2.UIWindows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_AbstractFactory2
{
	internal class UserSettingsForm
	{
		public void Render(IUIComponentFactory uiFactory)
		{
			//now is not neccesary implement a if logic to select which os is used
			uiFactory.CreateButton().Render();
			uiFactory.CreateCheckbox().Render();
		}
	}
}
