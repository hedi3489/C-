using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class User : Login
    {
        //Static Variable To Ensure No More Than One Instance Exists at a time
        static User user = null;
        protected bool IsMember { get; set; } = false;

        //Private Constructor
        public User(string username, string password, string name, bool isMember)
        {
            Username = username;
            Password = password;
            Name = name;
            IsMember = isMember;
        }

        //Accessible Method To Instantiate The Class
        //public static Login GetInstance(string username, string password, string name, bool isMember)
        //{
        //    if (user == null)
        //    {
        //        user = new User(username, password, name, isMember);
        //    }
        //    else
        //    {
        //        Console.WriteLine("A user is already logged in.");
        //    }
        //    return user;
        //}

        //Overriden Methods
        protected override Book FindBook(string bookNamePar)
        {
            throw new NotImplementedException();
        }

        protected override void LogOut()
        {
            user = null;
        }

        //Class Methods
        protected void BorrowBook()
        {

        }

        protected void ReturnBook()
        {

        }

        
    }
}