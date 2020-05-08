using System;
using System.Collections;
using System.Collections.Generic;

namespace Menu {

	public class Option : MenuItem {
        //==================== ATRIBUTES ====================//

        private bool State = false;

        private string OnText = "on  ";
        private string OffText = "off ";


        //==================== CONSTRUCTOR ====================//

        public Option(string Title) {
			base.Data.Add(State);
            base.Title = Title;
        }

        public Option(string Title, bool State) {
			base.Data.Add(State);
            base.Title = Title;
            this.State = State;
        }

        public Option(string Title, bool State, string OnText, string OffText) {
			base.Data.Add(State);
            base.Title   = Title;
            this.State   = State;
            this.OnText  = OnText;
            this.OffText = OffText;
        }

        public 


        //==================== METHODS ====================//

        //print componet into console
        public override string Show() {
            if(State) {
                return Title + ": " + OnText;
            }
            else {
                return Title + ": " + OffText;
            }
        }

        //action when enter is pressed
        public override bool Action() {
            State = !State;
			Data[0] = State;
            return true;
        }
    }


}