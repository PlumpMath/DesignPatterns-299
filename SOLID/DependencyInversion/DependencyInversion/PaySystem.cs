using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DependencyInversion
{
	internal abstract class PaySystem
	{
		public int payOperationTime;
		public readonly object _payLock = new object();

		public void Pay()
		{
			lock (_payLock)
			{
				Console.WriteLine("Start payment with {0} pay system", GetType().Name);
				Thread.Sleep(payOperationTime);
			}

			Console.WriteLine("Pay done by {0} pay system", GetType().Name);
		}
	}
}
