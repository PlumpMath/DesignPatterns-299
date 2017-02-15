using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator {

	public class UserData {
		public string Name { get; set; }
		public Int32 Age { get; set; } 
		public string Country { get; set; }
	}

	public static class UserDataHandler {
		private static UInt32 usersCounter;
		public static Dictionary<UInt32, UserData> usersData;

		static UserDataHandler() {
			usersData = new Dictionary<UInt32, UserData>();
		}

		public static void AddUser(UserData newUser) {
			usersData.Add(usersCounter, newUser);
			IncrementUsersCounter();
		}

		private static void IncrementUsersCounter() {
			usersCounter++;
		}

		public static void GettingUsersData() {
			/// Here we get our users data. So on and so on. :)
		}
	}
}
