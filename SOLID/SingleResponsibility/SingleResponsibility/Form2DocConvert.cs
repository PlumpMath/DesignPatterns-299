using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
	internal static class Form2DocConvert
	{
		public static void ToTxt(UserData userData, string path)
		{
			DocumentWriter docWriter = new TxtWriter();
			docWriter.Write(userData, path);
		}

		public static void ToPdf(UserData userData, string path)
		{
			DocumentWriter docWriter = new PdfWriter();
			docWriter.Write(userData, path);
		}
	}
}
