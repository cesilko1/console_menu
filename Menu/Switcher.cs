using System;
using System.Collections;
using System.Collections.Generic;

namespace Menu {

	public class Switcher : MenuItem {
        //==================== ATRIBUTES ====================//

        private bool State = false;

        private string OnText = "on  ";
        private string OffText = "off ";


        //==================== CONSTRUCTOR ====================//

        public Switcher(string Title) {
            base.Title = Title;
        }

        public Switcher(string Title, bool State) {
            base.Title = Title;
            this.State = State;
        }


        //==================== METHODS ====================//

        public override string Show() {
            if(State) {
                return Title + ": " + OnText;
            }
            else {
                return Title + ": " + OffText;
            }
        }

        public override bool Action() {
            State = !State;
            return true;
        }
    }

}