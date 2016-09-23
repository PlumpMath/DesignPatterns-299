using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
	internal interface IDataBaseController
	{
		void SavePlayerData(uint playerId, PlayerData playerData);

		PlayerData GetPlayerData(uint playerId);
	}
}
