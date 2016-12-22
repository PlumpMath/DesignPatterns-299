using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Strategy
{
    public class Program
    {
        public static void Main(string[] args)
        {
			LoggerManager logManager = new LoggerManager();

			logManager.Init(Logger.LogType.JSON);
			logManager.Log(new Data(101, "Jason"), "C:/Program Files/LogData/");

			logManager.Init(Logger.LogType.XML);
			logManager.Log(new Data(102, "Kate"), "C:/Program Files/LogData/");
			logManager.Log(new Data(103, "Rouney"), "C:/Program Files/LogData/");
		}
    }
}
