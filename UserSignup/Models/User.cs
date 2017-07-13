using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserSignup.Models
{
    public class User
    {

        private static int nextId = 1;

        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public int UserId { get; } 

        public User()
        {
            UserId = nextId;
            nextId++;

        }

        public User(string username, string password) : base()
        {
            Username = username;
            Password = password;
        }

        public User(string username, string password, string email) : base()
        {
            Username = username;
            Password = password;
            Email = email;
        }



    }
}
