using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DependencyInversion
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Console.ForegroundColor = ConsoleColor.DarkBlue;
			Console.BackgroundColor = ConsoleColor.White;
			Console.Clear();

			ShoppingCenter shoppingCenter = new ShoppingCenter();

			shoppingCenter.Buy(shoppingCenter.amazon, "Glasses", shoppingCenter.payPal, shoppingCenter.dhl);
			shoppingCenter.Buy(shoppingCenter.olx, "Phone", shoppingCenter.masterCard, shoppingCenter.interExpress);
			shoppingCenter.Buy(shoppingCenter.olx, "Pants", shoppingCenter.visa, shoppingCenter.dhl);
			shoppingCenter.Buy(shoppingCenter.amazon, "Notebook", shoppingCenter.masterCard, shoppingCenter.interExpress);

			Console.ReadKey(true);
		}

	}
}

