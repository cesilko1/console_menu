using System;
using System.Collections;
using System.Collections.Generic;

namespace Menu {

	public class Option : MenuItem{
		//==================== ATRIBUTES ====================//

		private string[] Options;
		private int State = 0;


		//==================== CONSTRUCTOR ====================//

		public Option(string Title, string[] Options) {

			base.Data.Add(State);
			base.Data[0] = Options[State];
			base.Title = Title;

			this.Options = new string[Options.Length];
			this.Options = Options;
		}
		

		//==================== METHODS ====================//

		public override string Show() {
			return Title + ": " + Options[State];
		}

		public override bool Action() {
			State += 1;

			if(State >= Options.Length) {
				State = 0;
			}

			Data[0] = Options[State];
			return true;
		}

	}

}