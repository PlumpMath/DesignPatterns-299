using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			GraphicalSettings.SetConsoleView();
			DataHandler.InitializeUserData();
			Form2DocConvert.ToPdf(DataHandler.userData, "D://VerySecretFolder/MoreSecretFolder/UserData/");
		}
	}
}
