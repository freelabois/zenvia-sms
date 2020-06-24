using System;
using System.Collections.Generic;
using System.Text;

namespace ZennviaSMSLib.Entities
{
    public class SendSmsRequest
    {
        public string from { get; set; }
        public string to { get; set; }
        public string schedule { get; set; }
        public string msg { get; set; }
        public string callbackOption { get; set; }
        public string id { get; set; }
        public string aggregateId { get; set; }
        public bool flashSms { get; set; }
    }
}
