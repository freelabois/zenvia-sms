using System;
using System.Collections.Generic;
using System.Text;

namespace ZenviaSMSLib.Entities
{
    public class SendSmsResponse
    {
        public string statusCode { get; set; }
        public string statusDescription { get; set; }
        public string detailCode { get; set; }
        public string detailDescription { get; set; }
    }
}
