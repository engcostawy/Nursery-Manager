
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NurseryManager.Models
{
    public class Food
    {
        public int Id { get; set; }
        public string Breakfast { get; set; }
        public string Launch { get; set; }
        public string Dinner { get; set; }
        public string Snack { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public Child Child { get; set; }
        public int ChildId { get; set; }
    }
}