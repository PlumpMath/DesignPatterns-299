﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
	internal interface IFlyable
	{
		void FlyToNewLocation(double latitude, double longitude);
	}
}
