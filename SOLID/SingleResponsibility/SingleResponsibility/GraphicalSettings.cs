using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
	internal class GraphicalSettings
	{
		public static void SetConsoleView()
		{
			Console.ForegroundColor = Config.consoleForegroundColor;
			Console.BackgroundColor = Config.consoleBackgroundColor;
			Console.Clear();
		}
	}
}
