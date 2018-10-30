using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace deve_web.Logic
{
    using Acces;
    public class LogInLogic
    {
        public bool IsUser(String user,String password) {
            crud crud = new crud();
            String username=null; 
            if (string.IsNullOrEmpty(username=crud.IsUser(user,SecurityLogic.Encriptar(password))))
            {
                return false;
            }
            else {
                //agregar variables de sesion con username
                return true;
            }
        }

    }
}