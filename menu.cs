using System;
using Menu;

public class main {
	public static void Main(string[] argv) {

		//create instance with menu header
		ConsoleMenu menu = new ConsoleMenu("Example menu");

		//adding items into menu
		menu.AddItem(new Button(" Yes "));    //item index 0
		menu.AddItem(new Button(" No "));     //item index 1
		menu.AddItem(new Input(" Name", "unnamed"));
		menu.AddItem(new Switcher(" Music")); //item index 2

		//method Display() returns index of pressed button and show interactive menu in console
		int menu_id = menu.Display();

		//write id of pressed button
		Console.WriteLine(menu_id);

		//write data of menu item with index 2
		Console.WriteLine(menu.GetData()[2]);
	}
}