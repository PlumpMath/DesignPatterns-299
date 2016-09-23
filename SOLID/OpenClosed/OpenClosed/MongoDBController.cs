using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
	internal class MongoDBController : IDataBaseController
	{
		public void SavePlayerData(uint playerId, PlayerData playerData)
		{
			// Saving into MongoDB database
		}

		public PlayerData GetPlayerData(uint playerId)
		{
			PlayerData playerData; // Getting data from MongoDB database
			return playerData;
		}
	}
}
