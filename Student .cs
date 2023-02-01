using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Task2.Models
{
    public class Student
    {
        public int ID { set; get; }
        public String Name { set; get; }
        public string Major { get; set; }
        public string Faculty { get; set; }
    }
}