using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
	internal static class DataHandler
	{
		public static UserData userData;

		public static UserData InitializeUserData()
		{
			userData = new UserData()
			{
				name = UserInput.ReadData("Name"),
				age = Convert.ToInt32(UserInput.ReadData("Age")),
				country = UserInput.ReadData("Country"),
				sex = UserInput.ReadData("Sex")
			};

			return userData;
		}
	}
}
