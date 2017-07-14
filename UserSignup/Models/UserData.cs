using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserSignup.Models
{
    public class UserData
    {

        //List
        private static List<User> users = new List<User>();

        //Add
        public void Add(User user)
        {
            users.Add(user);
        }
        
        //GetAll
        public List<User> GetAll()
        {
            return users;
        }

        //FindById
        public User FindById(int userId)
        {
            return users.Single(x => x.UserId == userId);
        }
    }
}
