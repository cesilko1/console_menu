using System;
using System.Collections;
using System.Collections.Generic;

namespace Menu {

	public class Input : MenuItem {
		//==================== ATRIBUTES ====================//

		//input data that is returned and displayed in console
		private string InputData = "";

		//cursor position
		private int CTop  = 0;

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

		//print componet into console
		public override string Show() {
			CTop  = Console.CursorTop;

			return Title + ": " + InputData;
		}

		//action when enter is preseed
		public override bool Action() {
			Console.CursorVisible = true;

			Console.SetCursorPosition(Title.Length+2, CTop);

			

			InputData = Console.ReadLine();

			Console.CursorVisible = false;

			Data[0] = InputData;
			return true;
		}
	}

}