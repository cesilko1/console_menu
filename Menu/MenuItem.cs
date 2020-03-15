using System;

namespace Menu {
	public abstract class MenuItem {
		//==================== ATRIBUTES ====================//

		protected string Title;

		public object Data;


		//==================== METHODS ====================//
		
		public abstract bool Action();

		public abstract string Show();

	}

}