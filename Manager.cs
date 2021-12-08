using System;
using System.Collections.Generic;
using System.Text;

namespace Work_Order_Management_System
{
    public class Manager:Employee
    {
        public List<Operator> crew { get; set; }
        public Manager()
        {
            crew = new List<Operator>();
        }
        public override string Worker_Position()
        {
           Position = "Manager";
            return Position;
        }
    }
}
