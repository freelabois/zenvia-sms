using System;
using System.Collections.Generic;
using System.Text;

namespace ZennviaSMSLib.Entities
{
    public class GetSmsStatusResp
    {
        public string id { get; set; }
        public string received { get; set; }
        public int shortcode { get; set; }
        public string mobileOperatorName { get; set; }
        public string statusCode { get; set; }
        public string statusDescription { get; set; }
        public string detailCode { get; set; }
        public string detailDescription { get; set; }
    }
}
