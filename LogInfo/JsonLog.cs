using System;
using Newtonsoft.Json;
using System.IO;

namespace LogInfo
{
    public class JsonLog : ILog
    {
        public void LoggError(string path, string message, object whoCalls)
        {
            var logObject = new Log()
            {
                Date = DateTime.Now,
                Caller = whoCalls.ToString(),
                Message = message,
                TypeOfLogger = "LoggError"
            };
            var jsonTextResult = JsonConvert.SerializeObject(logObject);
            var date = DateTime.Now.ToString();
            var format = ".log";
            using (var stream = File.CreateText($"{date}{format}"))
            {
                stream.WriteLine(jsonTextResult);
            }
        }

        public void LoggInformation(string path, string message, object whoCalls)
        {
            var logObject = new Log()
            {
                Date = DateTime.Now,
                Caller = whoCalls.ToString(),
                Message = message,
                TypeOfLogger = "LoggInformation"
            };
            var jsonTextResult = JsonConvert.SerializeObject(logObject);
            var date = DateTime.Now.ToString();
            var format = ".log";
            using (var stream = File.CreateText($"{date}{format}"))
            {
                stream.WriteLine(jsonTextResult);
            }
        }

        public void LoggWarning(string path, string message, object whoCalls)
        {
            var logObject = new Log()
            {
                Date = DateTime.Now,
                Caller = whoCalls.ToString(),
                Message = message,
                TypeOfLogger = "LoggWarning"
            };
            var jsonTextResult = JsonConvert.SerializeObject(logObject);
            var date = DateTime.Now.ToString();
            var format = ".log";
            using (var stream = File.CreateText($"{date}{format}"))
            {
                stream.WriteLine(jsonTextResult);
            }
        }
    }
}