using System;

namespace Menu {
	
      //******************************************//
	 //                  Button                  //
	//******************************************//

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






      //********************************************//
	 //                  Switcher                  //
	//********************************************//

    public class Switcher : MenuItem {
        //==================== ATRIBUTES ====================//

        Data = false;

        private string OnText = "on  ";
        private string OffText = "off ";


        //==================== CONSTRUCTOR ====================//

        public Switcher(string Title) {
            base.Title = Title;
        }

        public Switcher(string Title, bool State) {
            base.Title = Title;
            Data = State;
        }

        public override string Show() {
            if(Data) {
                return Title + ": " + OnText;
            }
            else {
                return Title + ": " + OffText;
            }
        }


        //==================== METHODS ====================//

        public override bool Action() {
            Data = !Data;
            return true;
        }
    }
}