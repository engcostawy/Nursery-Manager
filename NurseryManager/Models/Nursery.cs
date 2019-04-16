using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NurseryManager.Models
{
    public class Nursery
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Subscription Subscription { get; set; }
        public int SubscriptionId { get; set; }

    }
}