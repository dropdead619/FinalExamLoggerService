using System;
using System.Collections.Generic;
using System.IO;

namespace LogInfo
{
    public class LoggingService : ILog
    {
        public void LoggInformation(string path, string message, object whoCalls)
        {
            var date = DateTime.Now.ToString();
            var format = ".log";
            using (var stream = File.CreateText($"{date}{format}"))
            {
                stream.WriteLine($"Date: {date} {whoCalls.ToString()} LoggInformation: {message}");
            }
        }
        public void LoggWarning(string path, string message, object whoCalls)
        {
            var date = DateTime.Now.ToString();
            var format = ".log";
            using (var stream = File.CreateText($"{date}{format}"))
            {
                stream.WriteLine($"Date: {date} {whoCalls.ToString()} LoggWarning: {message}");
            }
        }
        public void LoggError(string path, string message, object whoCalls)
        {
            var date = DateTime.Now.ToString();
            var format = ".log";
            using (var stream = File.CreateText($"{date}{format}"))
            {
                stream.WriteLine($"Date: {date} {whoCalls.ToString()} LoggError: {message}");
            }
        }
    }
}