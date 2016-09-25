using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
	internal class Penguin : Bird, IWalkable, IMigratory
	{
		public void MigrationToNewLocation(double latitude, double longitude)
		{
			Migrate(latitude, longitude);
		}

		public void WalkToNewLocation(double latitude, double longitude)
		{
			Console.WriteLine("Walking to new location...");
		}

		public PreferableMigrationMethod Migrate { get; set; }

		public Penguin()
		{
			Migrate = WalkToNewLocation;
		}
	}
}
