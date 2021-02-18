using System;
using Newtonsoft.Json;

namespace LogInfo
{
    public class Log
    {
        [JsonProperty("date")]
        public DateTime Date { get; set; }
        [JsonProperty("caller")]
        public string Caller { get; set; }
        [JsonProperty("type_of_logger")]
        public string TypeOfLogger { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
