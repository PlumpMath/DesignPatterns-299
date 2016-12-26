using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;

namespace Strategy
{
	public abstract class Logger
	{
		public enum LogType
		{
			JSON,
			XML,
			TXT
		}
		public LogType logType;

		public Logger()
		{

		}

		public abstract void Log(Data data, string path);
	}

	public class JSONLogger : Logger
	{
		public override void Log(Data data, string path)
		{
			// JSON specific logging
		}

		public JSONLogger(){ }
	}

	public class XMLLogger : Logger {
		public override void Log(Data data, string path) {
			// XML specific logging
		}

		public XMLLogger(){ }
	}

	public class TXTLogger : Logger {
		public override void Log(Data data, string path) {
			// TXT specific logging
		}

		public TXTLogger() { }
	}
}
