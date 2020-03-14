using System;

namespace Menu {
	public abstract class MenuItem {
		//==================== ATRIBUTES ====================//

		protected string Title;


		//==================== METHODS ====================//
		
		public abstract void Action();

		public abstract string Show();

	}

}