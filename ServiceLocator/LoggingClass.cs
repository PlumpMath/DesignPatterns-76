using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ServiceLocator
{
    public class LoggingClass
    {
        private StreamWriter logFile;

        public void Log(string text)
        {
            InternalLog(text);
        }

        private void InternalLog(string text)
        {
            if(logFile == null)
            {
                logFile = new StreamWriter("actions.log");
            }
            logFile.WriteLine(text);
            logFile.Flush();
        }
    }
}
