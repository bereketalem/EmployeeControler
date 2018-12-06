using EmployeeControler.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeControler.ViewModels
{
    public class EmployeView
    {
        public string TaskName { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int Worker { get; set; }
        public IEnumerable<Worker> Workers { get; set; }
    }
}