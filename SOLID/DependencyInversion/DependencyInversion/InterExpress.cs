﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
	internal class InterExpress : PostSystem
	{
		public InterExpress()
		{
			postSendingTime = 3000;
		}
	}
}
