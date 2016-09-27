using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DependencyInversion
{
	internal abstract class Shop
	{
		public void Buy(string productName, PaySystem paySystem, PostSystem postSystem)
		{
			Thread payment = new Thread(paySystem.Pay);
			Thread parcelSending = new Thread(postSystem.SendParcel);
			payment.Start();
			payment.Join();
			parcelSending.Start();
			parcelSending.Join();
			Console.WriteLine("{0} was bought", productName);
		}
	}
}
