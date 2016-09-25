using System;

namespace LiskovSubstitution
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Animal colibri = new Colibri();
			Animal penguin = new Penguin();

			Migration(new Animal[] { colibri, penguin}, 30.3, 22.74 );

			Console.ReadKey(true);
		}

		private static void Migration(Animal[] animals, double latitude, double longitude)
		{
			foreach (var animal in animals)
			{
				IMigratory migratoryAnimal = animal as IMigratory;
				if (migratoryAnimal != null)
				{
					migratoryAnimal.Migrate(latitude, longitude);
				}
				
			}
		}
	}
}
