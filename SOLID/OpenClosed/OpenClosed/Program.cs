using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			PlayerData playerData = new PlayerData(100, 1);

			IDataBaseController dbController;

			// Not we use a SQLIte database for storing player data
			dbController = new SQLiteController();
			dbController.SavePlayerData(1, playerData);

			//But in another moment we might want to use MongoDB database
			dbController = new MongoDBController();
			dbController.SavePlayerData(3, playerData);
		}
	}
}
