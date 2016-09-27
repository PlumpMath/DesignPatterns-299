using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DependencyInversion
{
	internal class PayPal : PaySystem
	{
		public PayPal()
		{
			payOperationTime = 3000;
		}
	}
}
