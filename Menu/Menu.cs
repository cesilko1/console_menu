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

		public void AddItem(MenuItem Item) {
			MenuItems.Add(Item);
		}



		public int Display() {
			bool Running = true;

			Console.Clear();

			Console.CursorVisible = false;

			ConsoleKeyInfo btn;

			while(Running) {

				Console.Clear();

				Console.ResetColor();

				Console.ForegroundColor = TextColor;

				Console.WriteLine(MenuHeader + "\n");

				Console.ResetColor();

				for(int i = 0; i < MenuItems.Count; i++) {
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
					case ConsoleKey.UpArrow:
						if(ActiveItem > 0) {
							ActiveItem--;
						}
						else {
							ActiveItem = 0;
						}
						break;
					
					case ConsoleKey.DownArrow:
						if(ActiveItem < MenuItems.Count-1) {
							ActiveItem++;
						}
						else {
							ActiveItem = MenuItems.Count-1;
						}
						break;

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


		public ArrayList GetData() {
			ArrayList MenuData = new ArrayList();

			for(int i = 0; i < MenuItems.Count; i++) {
				MenuData.Add(MenuItems[i].Data);
			}

			return MenuData;
		}

	}

}