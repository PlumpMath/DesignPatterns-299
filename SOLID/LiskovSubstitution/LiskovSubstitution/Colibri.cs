using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
	internal class Colibri : Bird, IFlyable, IMigratory
	{
		public void MigrationToNewLocation(double latitude, double longitude)
		{
			Migrate(latitude, longitude);
		}

		public void FlyToNewLocation(double latitude, double longitude)
		{
			Console.WriteLine("Flying to new location...");
		}

		public PreferableMigrationMethod Migrate { get; set; }

		public Colibri()
		{
			Migrate = FlyToNewLocation;
		}
	}
}
