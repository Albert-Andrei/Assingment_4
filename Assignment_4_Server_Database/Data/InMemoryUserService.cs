using System;
using System.Collections.Generic;
using System.Linq;
using Assignment_4_Server_Database.DataAccess;
using Assignment_4_Server_Database.Model;

namespace Assignment_4_Server_Database.Data
{
    public class InMemoryUserService : IUserService
    {
        private List<User> users;
        private UserContext ctx;
        
        public InMemoryUserService()
        {
            ctx = new UserContext();
        }

        public User ValidateUser(string userName, string password)
        {
            users = ctx.User.Where(user => user.UserName.Equals(userName)).ToList();
            User first = users.FirstOrDefault(user => user.UserName.Equals(userName)); 

            if (first == null)
            {
                throw new Exception("User not found");
            }

            if (!first.Password.Equals(password))
            {
                throw new Exception("Incorrect password");
            }

            return first;
        }
    }
}