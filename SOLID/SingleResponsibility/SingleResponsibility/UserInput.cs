using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
	internal static class UserInput
	{
		private static void EmptyDataEnteredMessage()
		{
			Console.ForegroundColor = Config.consoleWarningMessageColor;
			Console.WriteLine("You have enter nothing. Try again.");
			Console.ForegroundColor = Config.consoleForegroundColor;
		}

		private static void DataToEnterMessage(string dataToEnter)
		{
			Console.WriteLine("Enter " + dataToEnter + ":");
		}

		private static string ReadEnteredData()
		{
			string enteredData = Console.ReadLine();

			while (enteredData.Length == 0)
			{
				EmptyDataEnteredMessage();
				enteredData = Console.ReadLine();
			}
			return enteredData;
		}

		public static string ReadData(string dataToRead)
		{
			DataToEnterMessage(dataToRead);
			return ReadEnteredData();
		}
	}
}
