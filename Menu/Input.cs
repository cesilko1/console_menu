using System;
using System.Collections;
using System.Collections.Generic;

namespace Menu {

	public class Input : MenuItem {
		//==================== ATRIBUTES ====================//

		private string InputData = "";

		//==================== CONSTRUCTORS ====================//

		public Input(string Title) {
			base.Title = Title;

			base.Data.Add(InputData);
		}

		public Input(string Title, string InputData) {
			base.Title     = Title;
			this.InputData = InputData;

			base.Data.Add(InputData);
		}

		//==================== METHODS ====================//

		public override bool Action() {
			Console.CursorVisible = true;
			Console.Clear();
			Console.Write(Title + ": ");

			InputData = Console.ReadLine();

			Console.CursorVisible = false;

			Data[0] = InputData;
			return true;
		}

		public override string Show() {
			return Title + ": " + InputData + " ";
		}
	}

}