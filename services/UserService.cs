using builders_Project.Models;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace license.services
{
    public class UserService
    {
        private readonly Context context;

        public UserService()
        {
            context = new Context();    
        }
        
        public string get_username(string username) 
        {
            User user = (User)context.users?.Where(p => p.UserName == username)?.FirstOrDefault();
            return user.UserName;
        }
        public User Get_User(string Username)
        {
            return context.users.FirstOrDefault(p => p.UserName == Username);
        }


        public string get_Password(string username)
        {
            User user = (User)context.users?.Where(p => p.UserName == username)?.FirstOrDefault();
            return user.Password;
        }
    }
}
