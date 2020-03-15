# Console menu

## Interactive console menu for C#

*v 0.1.0*

```csharp
using System;
using Menu;

public class main {
	public static void Main(string[] argv) {

		//create instance with menu header
		ConsoleMenu menu = new ConsoleMenu("Example menu");

		//adding items into menu
		menu.AddItem(new Button(" Yes "));
		menu.AddItem(new Button(" No "));

		//method Show() returns index of pressed button
		int menu_id = menu.Show();

		
		Console.WriteLine(menu_id);
	}
}
```