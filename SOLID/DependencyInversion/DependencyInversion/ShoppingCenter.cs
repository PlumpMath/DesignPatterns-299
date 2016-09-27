using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace DependencyInversion
{
	internal class ShoppingCenter
	{
		public PaySystem visa = new Visa();
		public PaySystem masterCard = new MasterCard();
		public PaySystem payPal = new PayPal();

		public PostSystem dhl = new DHL();
		public PostSystem interExpress = new InterExpress();

		public Shop amazon = new Amazon();
		public Shop olx = new OLX();
		public Shop aliexpress = new Aliexpress();

		public void Buy(Shop shop, string productName, PaySystem paySystem, PostSystem postSystem)
		{
			Thread buyThread = new Thread(() => shop.Buy(productName, paySystem, postSystem));
			buyThread.Start();
		}
	}
}
