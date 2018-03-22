using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Helpers.Models
{
    public class Task
    {
        public Int64 TaskId { set; get; }
        public String Name { set; get; }
        public String Description { set; get; }
        public Project Project { set; get; }
        public Int64 ProjectId { set; get; }
    }
}