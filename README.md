# Console menu

## Interactive console menu for C#

*v 1.0.0*

---

### short example code
```csharp
using System;
using Menu;

public class main {
	public static void Main(string[] argv) {

		//create instance with menu header
		ConsoleMenu menu = new ConsoleMenu("Example menu");

		//adding items into menu
		menu.AddItem(new Button(" Yes "));    //item index 0
		menu.AddItem(new Button(" No "));     //item index 1
		menu.AddItem(new Switcher(" Music")); //item index 2

		//method Display() returns index of pressed button and show interactive menu in console
		int menu_id = menu.Display();

		//write id of pressed button
		Console.WriteLine(menu_id);

		//write data of menu item with index 2
		Console.WriteLine(menu.GetData()[2]);
	}
}
```

---

### Available menu items

* **Button()**
	* closes the menu and returns index of item

* **Switcher()**
	* switches between on and off