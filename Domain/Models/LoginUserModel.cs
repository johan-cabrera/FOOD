using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;

namespace Domain.Models
{
    public class LoginUserModel
    {
        LoginUser login = new LoginUser();

        public bool Login(string user, string pass) 
        { 
            return login.Login(user, pass);
        }
    }
}
