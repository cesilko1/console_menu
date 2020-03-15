using System;

namespace Menu {
	
      //******************************************//
	 //                  Button                  //
	//******************************************//

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

        public override bool Action() {
            return false;
        }
	}






      //********************************************//
	 //                  Switcher                  //
	//********************************************//

    public class Switcher : MenuItem {
        //==================== ATRIBUTES ====================//

        public bool State = false;

        private string OnText = "on  ";
        private string OffText = "off ";


        //==================== CONSTRUCTOR ====================//

        public Switcher(string Title) {
            this.Title = Title;
        }

        public Switcher(string Title, bool State) {
            this.Title = Title;
            this.State = State;
        }

        public override string Show() {
            if(State) {
                return Title + ": " + OnText;
            }
            else {
                return Title + ": " + OffText;
            }
        }


        //==================== METHODS ====================//

        public override bool Action() {
            State = !State;
            return true;
        }
    }
}