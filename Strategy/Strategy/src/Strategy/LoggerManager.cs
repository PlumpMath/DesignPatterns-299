using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Strategy
{
    public class LoggerManager
    {
	    private Logger logger;

	    public void Log(Data data, string path)
	    {
		    logger.Log(data, path);
	    }

	    public void Init(Logger.LogType logType)
	    {
		    switch (logType)
		    {
				case Logger.LogType.JSON:
				logger = new JSONLogger();
				break;
				case Logger.LogType.XML:
				logger = new XMLLogger();
				break;
				case Logger.LogType.TXT:
				logger = new TXTLogger();
				break;
		    }
	    }
    }
}
