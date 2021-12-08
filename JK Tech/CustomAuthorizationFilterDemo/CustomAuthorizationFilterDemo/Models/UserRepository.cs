using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomAuthorizationFilterDemo.Models
{
   
    public class UserRepository
    {
        JkTech_CF_DBEntities db = new JkTech_CF_DBEntities();
        public USER GetUserDetails(string username, string password)
        {
            USER user = db.USERS.FirstOrDefault(u => u.UserName == username.ToLower() &&
           u.Password == password.ToLower());
            return user;
        }
    }
}