using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NurseryManager.Models
{
    public class Class
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
        public Nursery Nursery { get; set; }
        public int NurseryId { get; set; }

    }
}