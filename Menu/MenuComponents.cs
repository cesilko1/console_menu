using System;

namespace Menu {
    public class Button : MenuItem{
		//==================== ATRIBUTES ====================//


		//==================== CONSTRUCTOR ====================//

		public Button(string Title) {
			this.Title = Title;
		}


		//==================== METHODS ====================//

		public override string Show() {
			return Title;
		}

        public override void Action() {
        }
	}


    public class Switcher : MenuItem {
        //==================== ATRIBUTES ====================//

        public bool State = false;

        private string OnText = "on";

        private string OffText = "off";


        //==================== CONSTRUCTOR ====================//

        public Switcher(string Title) {
            this.Title = Title;
        }

        public override string Show() {
            return Title;
        }

        public override void Action() {
            
        }
    }
}