using System;
using Menu;

public class main {
	public static void Main(string[] argv) {

		//create instance with menu header, set true for looped menu cursor
		ConsoleMenu menu = new ConsoleMenu("Example menu", true);

		//adding items into menu
		menu.AddItem(new Button("Yes"));    //item index 0
		menu.AddItem(new Button("No"));     //item index 1
		menu.AddItem(new Input("Name"));     //item index 2
		menu.AddItem(new Switcher("Music")); //item index 3

		//method Display() returns index of pressed button and show interactive menu in console
		int menu_id = menu.Display();

		//write id of pressed button
		Console.WriteLine(menu_id);

		//write data of menu item with index 2
		Console.WriteLine(menu.GetData()[2]);

		//write data of menu item with index 3
		Console.WriteLine(menu.GetData()[3]);
	}
}