using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NurseryManager.Models
{
    public class Mood
    {
        public int Id { get; set; }
        public string ChildMood { get; set; }
        public DateTime Date { get; set; }
        public Child Child { get; set; }
        public int ChildId { get; set; }

    }
}