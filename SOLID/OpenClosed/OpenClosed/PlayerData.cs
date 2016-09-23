using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
	internal class PlayerData
	{
		public uint scores;
		public uint currentLevel;

		public PlayerData(uint scores, uint currentLevel)
		{
			this.scores = scores;
			this.currentLevel = currentLevel;
		}
	}
}
