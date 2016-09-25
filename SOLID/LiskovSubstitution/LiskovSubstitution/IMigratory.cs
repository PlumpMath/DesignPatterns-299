using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
	public delegate void PreferableMigrationMethod(double latitude, double longitude);

	internal interface IMigratory
	{	
		PreferableMigrationMethod Migrate { get; set; }
		void MigrationToNewLocation(double latitude, double longitude);
	}
}
