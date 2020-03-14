using System;
using System.Collections;
using System.Collections.Generic;

namespace Menu {
	public class ConsoleMenu {
		//==================== ATRIBUTES ====================//

		//list of console components
		private ArrayList MenuItems = new ArrayList();

		//header of menu
		private string MenuHeader;

 
		//color defintions
		public ConsoleColor TextColor = ConsoleColor.Red;
		public ConsoleColor HighlightColor = ConsoleColor.Blue;


		//==================== CONSTRUCTOR ====================//

		public ConsoleMenu(string MenuHeader) {
			this.MenuHeader = MenuHeader;
		}


		//==================== METHODS ====================//

		public void AddItem<T>(T Item) {
			MenuItems.Add(Item);
		}

		public void Show() {
			Console.WriteLine((MenuItems[0] as ConsoleMenu).Show());
		}

	}

}