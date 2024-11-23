using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEEE_Task2
{
    internal class User
    {
        public string  FName {  get; set; }
        public string  LName {  get; set; }
        public string  Phone {  get; set; }
         
        public User() { }
        public User(string fname ,string lname ,string phone) 
        {
            FName = fname;
            LName = lname;
            Phone = phone;
        }
        public void Set_FName(string fname)
        {
            FName = fname;
        }
        public void Set_LName(string lname)
        {
            LName = lname;
        }
        public void Set_Phone(string phone)
        {
            Phone = phone;
        }
        public string Get_FName()
        {
            return FName;
        }
        public string Get_LName()
        {
            return LName;
        }
        public string Get_Phone()
        {
            return Phone;
        }
        public void Display()
        {
            Console.WriteLine($"Name :{FName} {LName} Phone Number : {Phone}");
            Console.WriteLine("");
        }
        public override string ToString()
        {
            return $"Name :{FName} {LName} Phone Number : {Phone}";
        }

    }
}
