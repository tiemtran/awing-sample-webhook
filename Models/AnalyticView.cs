using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebhookTestAPI.Models
{
    public class AnalyticView
    {
        public long PlaceId { get; set; }
        public long DomainId { get; set; }
        public long CampaignId { get; set; }
        public string CampaignType { get; set; }
        public string MacAddress { get; set; }
        public string ApMac { get; set; }
        public string PageCode { get; set; }
        public string SessionId { get; set; }
        public string Url { get; set; }
        public string UserAgent { get; set; }
        public Timestamp CreatedDate { get; set; }
    }
}
