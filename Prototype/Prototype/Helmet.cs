using System;
using System.Runtime.CompilerServices;

namespace Prototype
{
	public class Helmet : Module
	{
		public Int32 Visibility { get; set; }

		public Helmet()
		{
			Wearability = 100;
			Visibility = 100;
		}
	}
}