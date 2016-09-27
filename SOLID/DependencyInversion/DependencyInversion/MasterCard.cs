using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DependencyInversion
{
	internal class MasterCard : PaySystem
	{
		public MasterCard()
		{
			payOperationTime = 4000;
		}
	}
}
