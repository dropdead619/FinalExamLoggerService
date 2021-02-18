using System;
using System.Collections.Generic;
using System.Text;

namespace LogInfo
{
    public interface ILog
    {
        public void LoggInformation(string path, string message, object whoCalls);
        public void LoggWarning(string path, string message, object whoCalls);
        public void LoggError(string path, string message, object whoCalls);
        }
}
