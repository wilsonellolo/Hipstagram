using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace deve_web.Logic
{
    using Acces;
    public class SingUpLogic
    {

        public bool  InsertUser(String username, String name, String lastname, String birthday, String password, String mail, String status){
            crud crud = new crud();
            return crud.SingUpUser(username,name,lastname,birthday,SecurityLogic.Encriptar(password),mail,status);
        }

    }
}