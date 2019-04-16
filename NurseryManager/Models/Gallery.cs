using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NurseryManager.Models
{
    public class Gallery
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public Class Class { get; set; }
        public int ClassId { get; set; }

    }
}