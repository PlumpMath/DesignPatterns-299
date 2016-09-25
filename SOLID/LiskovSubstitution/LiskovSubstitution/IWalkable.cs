using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
	internal interface IWalkable
	{
		void WalkToNewLocation(double latitude, double longitude);
	}
}
