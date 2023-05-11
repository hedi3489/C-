using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Supplier : Login
    {
        //Static Variable To Ensure No More Than One Instance Exists at a time
        static Supplier supplier = null;

        //Private Constructor
        private Supplier(string username, string password, string name)
        {
            Username = username;
            Password = password;
            Name = name;
        }

        //Accessible Method To Instantiate The Class
        public static Login GetInstance(string username, string passwrod, string name)
        {
            if (supplier == null)
            {
                supplier = new Supplier(username, passwrod, name);
            }
            else
            {
                Console.WriteLine("A supplier is already logged in.");
            }
            return supplier;
        }

        //Overriden Methods
        protected override Book FindBook(string bookName)
        {
            return null;
        }
        protected override void LogOut()
        {
            supplier = null;
        }
    }
}