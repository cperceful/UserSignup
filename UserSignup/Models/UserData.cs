using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserSignup.Models
{
    public static class UserData
    {

        //List
        private static List<User> users = new List<User>();

        //Add
        public static void Add(User user)
        {
            users.Add(user);
        }
        
        //GetAll
        public static List<User> GetAll()
        {
            return users;
        }

        //FindById
        public static User FindById(int userId)
        {
            return users.Single(x => x.UserId == userId);
        }
    }
}
