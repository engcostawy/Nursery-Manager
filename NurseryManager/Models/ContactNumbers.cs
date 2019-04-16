using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NurseryManager.Models
{
    public class ContactNumbers
    {
        public int Id { get; set; }
        public string ContactName { get; set; }
        public string PhoneNumber { get; set; }
        public Contact Contact { get; set; }
        public int ContactId { get; set; }

    }
}