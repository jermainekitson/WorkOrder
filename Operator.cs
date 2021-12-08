using System;
using System.Collections.Generic;
using System.Text;

namespace Work_Order_Management_System
{
    public class Operator:Employee
    {
        public override string Worker_Position()
        {
            Position = "Operator";
            return Position;
        }

    }
}
