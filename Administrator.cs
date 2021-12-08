using System;
using System.Collections.Generic;
using System.Text;

namespace Work_Order_Management_System
{
   public class Administrator:Employee
    {
        public List<Operator> employOrTerminate { get; set; }
        public Administrator()
        {
            employOrTerminate = new List<Operator>();
        }
        public override string Worker_Position()
        {
            Position = "Administrator";
            return Position; 
        }
       
    }
}
