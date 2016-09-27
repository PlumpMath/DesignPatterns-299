using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DependencyInversion
{
	internal abstract class PostSystem
	{
		public int postSendingTime;
		public readonly object _postLock = new object();

		public void SendParcel()
		{
			lock (_postLock)
			{
				Thread.Sleep(postSendingTime);
			}

			Console.WriteLine("Parcel send by {0} post system", GetType().Name);
		}
	}
}
