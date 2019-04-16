using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NurseryManager.Models
{
    public class Drink
    {
        public int Id { get; set; }
        public string Water { get; set; }
        public string Milk { get; set; }
        public DateTime Date { get; set; }
        public Child Child { get; set; }
        public int ChildId { get; set; }
    }
}