using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Task4
{
    internal class User
    {
        public string Username;
        public string Password;
        public string Email;
        public bool LoggedIn;

        public User(string username, string password)
        {
            Username = username;
            Password = password;
            LoggedIn = false;
        }

        public User(string username, string password, string email) : this(username, password) 
        {
            Email = email;
        }



        static void Login(bool LoggedIn)
        {
            if (LoggedIn == false) 
            { 
                Console.WriteLine("Istifadəçi hesaba daxil oldu");
            }
            else 
            {
                Console.WriteLine("Istifadəçi öncədən hesaba daxil olub");
            }
        }
        static void Logout(bool LoggedIn)
        {
            if (LoggedIn == true)
            {
                Console.WriteLine("Istifadəçi hesabdan çıxış etdi ");
            }
            else
            {
                Console.WriteLine("Istifadəçi hesaba giriş etməyib");
            }
        }
    }
}
