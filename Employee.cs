using System;
using System.Collections.Generic;
using System.Text;

namespace Work_Order_Management_System
{
    public abstract class Employee
    {
        public int Employee_ID { get; set; }
        public string Position { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public  DateTime Hire_Date { get; set; }
        public string Email_Address { get; set; }
        public string Phone_Number { get; set; }
       
        //This method will demonstrate Polymorphism
        public virtual string Worker_Position()
        {
            Position = "Employee";
            return Position;
        }
        public override string ToString()
        {
            
            return Position; //+" " + Last_Name + " " + Gender + " " + Address + " " + Hire_Date + " " + Email_Address + " " + Phone_Number;
        }


    }
}
