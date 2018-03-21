using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Helpers.Models
{
    public class Student
    {
        public Int64 StudentId { set; get; }
        public string StringData { set; get; }
        public int IntData { set; get; }
        public bool BoolData { set; get; }
        public DateTime DateTimeData { set; get; }

        // Many To One 
        public Int64 GroupId { set; get; }
        public Group Group { set; get; }

        // Many to Many

    }
}