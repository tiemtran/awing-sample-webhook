using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebhookTestAPI.Models
{
    public class AnalyticEvent
    {
        public long DomainId { get; set; }
        public long PageId { get; set; }
        public long CampaignId { get; set; }
        public string ApMac { get; set; }
        public string SessionId { get; set; }
        public string MacAddress { get; set; }
        public long PlaceId { get; set; }
        public Timestamp CreatedDate { get; set; }
        public string EventLabel { get; set; }
        public string EventObject { get; set; }
    }
}
