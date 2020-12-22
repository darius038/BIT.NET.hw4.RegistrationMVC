using RegistrationMVC.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationMVC.WebApp.Repository
{
    public class UserData:IUserData
    {
        private List<User> _users = new List<User>();
 
        public User GetUser()
        {
            return _users.LastOrDefault();
        }
        public void AddUser(User user)
        {
           _users.Add(user);
        }
    }
}
