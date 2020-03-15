using System;
using System.Collections;
using System.Collections.Generic;

namespace Menu {

	public class Button : MenuItem{
		//==================== ATRIBUTES ====================//

		//==================== CONSTRUCTOR ====================//

		public Button(string Title) {
			base.Title = Title;
		}


		//==================== METHODS ====================//

		public override string Show() {
			return Title;
		}

        public override bool Action() {
            return false;
        }
	}

}