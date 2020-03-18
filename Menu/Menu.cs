using System;
using System.Collections;
using System.Collections.Generic;

namespace Menu {
	public class ConsoleMenu {
		//==================== ATRIBUTES ====================//

		//list of console components
		private List<MenuItem> MenuItems = new List<MenuItem>();

		//header of menu
		private string MenuHeader;

		//index of activated menu item
		private int ActiveItem = 0;

 
		//color defintions
		public ConsoleColor TextColor           = ConsoleColor.Green;
		public ConsoleColor HighlightBackground = ConsoleColor.Green;
		public ConsoleColor HighlightText       = ConsoleColor.Black;


		//==================== CONSTRUCTOR ====================//

		public ConsoleMenu(string MenuHeader) {
			this.MenuHeader = MenuHeader;
		}


		//==================== METHODS ====================//

		//add new menu item into menu
		public void AddItem(MenuItem Item) {
			MenuItems.Add(Item);
		}

		//opens teh menu and returns index of pressed button
		public int Display() {

			//true when menu is opened
			bool Running = true;

			//set console
			Console.Clear();
			Console.CursorVisible = false;

			//pressed button
			ConsoleKeyInfo btn;

			while(Running) {

				//set console colores
				Console.Clear();
				Console.ResetColor();
				Console.ForegroundColor = TextColor;

				//print menu header
				Console.WriteLine(MenuHeader + "\n");

				Console.ResetColor();

				//list and print all menu items
				for(int i = 0; i < MenuItems.Count; i++) {

					//it item is active, then print highlighted item
					if(i == ActiveItem) {
						Console.ForegroundColor = HighlightText;
						Console.BackgroundColor = HighlightBackground;
						Console.WriteLine(MenuItems[i].Show());
						Console.ResetColor(); 
					}
					else {
						Console.ForegroundColor = TextColor;
						Console.WriteLine(MenuItems[i].Show());
						Console.ResetColor();
					}
				}				

				btn = Console.ReadKey();

				switch(btn.Key) {

					//activate item on the activeted item
					case ConsoleKey.UpArrow:
						if(ActiveItem > 0) {
							ActiveItem--;
						}
						else {
							ActiveItem = 0;
						}
						break;
					
					//activate item under the activeted item
					case ConsoleKey.DownArrow:
						if(ActiveItem < MenuItems.Count-1) {
							ActiveItem++;
						}
						else {
							ActiveItem = MenuItems.Count-1;
						}
						break;

					//activete item when enter is pressed
					case ConsoleKey.Enter:
						Running = MenuItems[ActiveItem].Action();
						break;

					default:
						break;
				}

			}
			Console.CursorVisible = true;

			return ActiveItem;
		}

		//returns data from all menu items
		public ArrayList GetData() {
			ArrayList MenuData = new ArrayList();

			for(int i = 0; i < MenuItems.Count; i++) {
				//some items don't have data (e.g. Button)
				try {
					MenuData.Add(MenuItems[i].Data[0]);
				}
				catch {
					MenuData.Add(null);
				}
			}

			return MenuData;
		}

	}

}