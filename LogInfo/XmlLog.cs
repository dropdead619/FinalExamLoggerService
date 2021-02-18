using System;
using System.Xml;
using System.IO;

namespace LogInfo
{
    public class XmlLog : ILog
    {
        public void LoggError(string path, string message, object whoCalls)
        {
            var xmlFile = ParseXml("LoggError", message, whoCalls);
            var date = DateTime.Now.ToString();
            var format = ".log";
            using (var stream = File.CreateText($"{date}{format}"))
            {
                stream.WriteLine(xmlFile);
            }
        }

        public void LoggInformation(string path, string message, object whoCalls)
        {
            var xmlFile = ParseXml("LoggInformation", message, whoCalls);
            var date = DateTime.Now.ToString();
            var format = ".log";
            using (var stream = File.CreateText($"{date}{format}"))
            {
                stream.WriteLine(xmlFile);
            }
        }

        public void LoggWarning(string path, string message, object whoCalls)
        {
            var xmlFile = ParseXml("LoggWarning", message, whoCalls);
            var date = DateTime.Now.ToString();
            var format = ".log";
            using (var stream = File.CreateText($"{date}{format}"))
            {
                stream.WriteLine(xmlFile);
            }
        }
        private string ParseXml(string msgType, string msg, object whoCalls)
        {
            var log = new LoggingService();
            var xmlDocument = new XmlDocument();
            var xmlDeclaration = xmlDocument.CreateXmlDeclaration("1.0", "utf-8", string.Empty);
            xmlDocument.AppendChild(xmlDeclaration);
            var rootElement = xmlDocument.CreateElement("log");
            xmlDocument.AppendChild(rootElement);
            var time = xmlDocument.CreateElement("time");
            var type = xmlDocument.CreateElement("type");
            var messageType = xmlDocument.CreateElement("messageType");
            var message = xmlDocument.CreateElement("message");
            rootElement.AppendChild(time);
            rootElement.AppendChild(type);
            rootElement.AppendChild(messageType);
            rootElement.AppendChild(message);
            time.SetAttribute("date: ", DateTime.Now.ToString());
            type.SetAttribute("type: ", whoCalls.ToString());
            messageType.SetAttribute("message_type: ", msgType);
            message.SetAttribute("message: ", msg);

            return xmlDocument.InnerText;
        }
    }
}
