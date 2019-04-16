using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NurseryManager.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Website { get; set; }
        public Nursery Nursery { get; set; }
        public int NurseryId { get; set; }

    }
}