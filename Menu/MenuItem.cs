using System;
using System.Collections;
using System.Collections.Generic;

namespace Menu {
	public abstract class MenuItem {
		//==================== ATRIBUTES ====================//

		//item title
		protected string Title;

		//item data
		public ArrayList Data = new ArrayList();


		//==================== METHODS ====================//

		//action vhen pressed enter om menu item
		//
		//Returns false, if the item closes the menu.
		//Returns true, if the item 	only sets the input value.	
		public abstract bool Action();

		//show item in console
		//
		//Returns string which should be displayed in console.
		public abstract string Show();

	}

}