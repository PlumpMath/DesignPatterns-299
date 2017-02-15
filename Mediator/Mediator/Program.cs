using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator {
	class Program {
		static void Main(string[] args) {
			UserDataHandler.GettingUsersData();
			// Some time have passed
			UserDataHandler.GettingUsersData();
			// More time have passed
			UserDataHandler.GettingUsersData();

			// Now we need to save users data and for that purpose we have class DataSavingManager that is mediator at this relationship model.
			// He can use proper data base buffer or other way of saving data, and also he has access to users data

			DataSavingManager.SaveUsersData();
		}
	}
}
