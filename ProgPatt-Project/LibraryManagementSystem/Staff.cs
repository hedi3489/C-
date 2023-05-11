using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Staff : Login
    {
        //Static Variable To Ensure No More Than One Instance Exists at a time
        static Staff staff = null;

        //Private Constructor
        private Staff(string username, string password, string name)
        {
            Username = username;
            Password = password;
            Name = name;
        }

        //Accessible Method To Instantiate The Class
        public static Login GetInstance(string username, string password, string name)
        {
            if (staff == null)
            {
                staff = new Staff(username, password, name);
            }
            else
            {
                Console.WriteLine("A staff member is already logged in.");
            }
            return staff;
        }

        //Overriden Methods
        protected override Book FindBook(string bookName)
        {
            return null;
        }
        protected override void LogOut()
        {
            staff = null;
        }

        //Class methods
        private void addBook(Book bookName)
        {

        }
        private void markBook(Book bookName)
        {

        }
        private void modifyBookInfo(Book bookName)
        {

        }
        private void lendBook(Book bookName)
        {

        }
        //private void addmember()
        //{

        //}
    }
}