/*
 Abtract Factory pattern provide an interface for creating families of releated objects, without the relative concrete class
 
 */
using Creational_AbstractFactory2;
using Creational_AbstractFactory2.UIWindows;

OperatingSystemType osType = OperatingSystemType.Windows;
UserSettingsFormBAD usForms = new UserSettingsFormBAD();
usForms.Render(osType);

Console.WriteLine("*****************Use a Abstract Factory pattern");

IUIComponentFactory uIComponentFactory;
//now, this brenching is only necessary only during the initialization phase
if (osType == OperatingSystemType.Mac)
{
	uIComponentFactory = new MacUIComponentFactory();
}
else if (osType == OperatingSystemType.Windows)
{
	uIComponentFactory = new WindowsUIComponentFactory();
}
else
{
	throw new ArgumentException();
}
UserSettingsForm usSettings =  new UserSettingsForm();
usSettings.Render(uIComponentFactory);