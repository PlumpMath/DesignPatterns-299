using System;
using System.Collections.Generic;

namespace Prototype
{
	internal class Program
	{
		public static Robot charlieTheFirst;
		public static Robot mikeyTheGreat;

		private static void Main(string[] args)
		{
			charlieTheFirst = new Robot
			(new Body(), new Engine(), new Helmet());

			mikeyTheGreat = new Robot
			(new Body(), new Engine(), new Helmet());

			DebugRobotsInfo();
			Console.WriteLine(String.Empty);

			// Fight between out best robots. Do everything for ood
			RobotsFight();
			Console.WriteLine("Fight!");

			DebugRobotsInfo();
			Console.WriteLine(String.Empty);

			Console.WriteLine("We need our mikey the great, so let's replace the helmets");
			Factory.Replace(ref charlieTheFirst.helmet, ref mikeyTheGreat.helmet);
			Console.WriteLine(String.Empty);

			DebugRobotsInfo();

			Console.ReadKey(true);
		}

		private static void DebugRobotsInfo()
		{
			Console.WriteLine("Visibility of charlie the first helmet: " + charlieTheFirst.helmet.Visibility);
			Console.WriteLine("Visibility of mikey the great helmet: " + mikeyTheGreat.helmet.Visibility);
			Console.WriteLine("Wearability of charlie the first engine: " + charlieTheFirst.engine.Wearability);
			Console.WriteLine("Wearability of mikey the great engine: " + mikeyTheGreat.engine.Wearability);
		}

		private static void RobotsFight()
		{
			charlieTheFirst.helmet.Visibility = 90;
			charlieTheFirst.engine.Wearability = 60;
			mikeyTheGreat.helmet.Visibility = 20;
			mikeyTheGreat.engine.Wearability = 65;
		}
	}
}


