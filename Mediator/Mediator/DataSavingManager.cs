using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator {
	public static class DataSavingManager {

		public static void SaveUsersData() {
			Dictionary<UInt32, UserData> usersData = UserDataHandler.usersData;
			DataBaseController.SaveData(usersData);
		}
	}
}
