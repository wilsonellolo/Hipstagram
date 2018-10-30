using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace deve_web.Acces
{
    public class crud
    {
        public bool SingUpUser(String username,String name, String lastname,String birthday,String password, String mail, String status )
        {

            MySqlConnection conexion = new MySqlConnection(Variables.StringConection);
            try
            {
                conexion.Open();
                String consulta = "insert into User(username, name, lastname, birthday, password_, mail, status_)values('"+username+"', '"+name+"', '"+lastname+"', '"+birthday+"', '"+password+"', '"+mail+"', '"+status+"');";
                MySqlCommand cm = new MySqlCommand(consulta, conexion);
                cm.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public String IsUser( String user, String password)
        {

            MySqlConnection conexion = new MySqlConnection(Variables.StringConection);
            try
            {
                conexion.Open();


                MySqlCommand comando = new MySqlCommand("select username from User where username ='"+user+"' and password_='"+password+"';", conexion);
                MySqlDataReader myreader = comando.ExecuteReader();
                myreader.Read();
                String username = myreader["username"].ToString();
                return username;
            }
            catch (Exception ex)
            {

                return null;
            }

        }
    }
}