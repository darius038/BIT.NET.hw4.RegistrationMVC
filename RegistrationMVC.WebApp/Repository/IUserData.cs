using RegistrationMVC.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationMVC.WebApp.Repository
{
    public interface IUserData
    {
        public User GetUser();
        public void AddUser(User user);

    }
}
