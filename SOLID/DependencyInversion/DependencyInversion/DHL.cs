using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
	internal class DHL : PostSystem
	{
		public DHL()
		{
			postSendingTime = 6000;
		}
	}
}
