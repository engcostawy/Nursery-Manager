using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NurseryManager.Models
{
    public class Events
    {
        public int Id { get; set; }
        public string EventName { get; set; }
        public string Description { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public Class Class { get; set; }
        public int ClassId { get; set; }

    }
}