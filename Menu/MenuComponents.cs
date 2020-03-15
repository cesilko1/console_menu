using System;

namespace Menu {
	
      //******************************************//
	 //                  Button                  //
	//******************************************//

    public class Button : MenuItem{
		//==================== ATRIBUTES ====================//

        public bool Data;

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

        public bool Data = false;

        private string OnText = "on  ";
        private string OffText = "off ";


        //==================== CONSTRUCTOR ====================//

        public Switcher(string Title) {
            this.Title = Title;
        }

        public Switcher(string Title, bool State) {
            this.Title = Title;
            this.Data = State;
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