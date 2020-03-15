using System;

namespace Menu {
	public abstract class MenuItem {
		//==================== ATRIBUTES ====================//

		//item title
		protected string Title;

		//tata to return
		protected var Data;



		//==================== METHODS ====================//

		//action vhen pressed enter om menu item		
		public abstract bool Action();

		//show item in console
		public abstract string Show();

	}

}