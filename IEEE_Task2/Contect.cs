using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace IEEE_Task2
{
    internal class Contect
    {
        public List<User> users=new List<User>();

        public void AddContect ()
        {
            Console.WriteLine("Enter your Phone Number");
            string phone = Console.ReadLine();
            Console.WriteLine("Enter your First Name");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter your Last Name");
            string lname = Console.ReadLine();           
            User user = new User(fname,lname,phone);
            users.Add(user);
            Console.WriteLine("Contect added seccessfully");
        }
        public void Edit () {

            Console.Write("Enter The Phone Number To search for Contact ");
            string num =Console.ReadLine();
            User us= users.FirstOrDefault(x => x.Phone == num);
            Console.WriteLine("Enter The New  First Name");
            us.Set_FName(Console.ReadLine());
            Console.WriteLine("Enter The New Last Name");
            us.Set_LName(Console.ReadLine());
        }
        public void RemoveContect () 
        {
            Console.WriteLine("Enter The Phone Number To Delete");
            string num = Console.ReadLine();
            users.Remove(users.FirstOrDefault(x => x.Phone == num));
            
        }

        public void ShowAllContects()
        {
            foreach (User user in users)
            {
                user.Display();
            }
        }

    }
}
