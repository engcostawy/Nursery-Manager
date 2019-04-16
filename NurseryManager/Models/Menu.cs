using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NurseryManager.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public string Breakfast { get; set; }
        public string Launch { get; set; }
        public string Dinner { get; set; }
        public string Snack { get; set; }
        public int Day { get; set; }
        public Class Class { get; set; }
        public int ClassId { get; set; }

    }
}