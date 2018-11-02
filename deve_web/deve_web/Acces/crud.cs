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
                conexion.Close();
                return username;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
 
        public String IsInserted(byte[] image, String descripcion)
        {
            String alias = DateTime.Now.ToString("yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss.fffffffK") + "wicho";
            String alias1 = "wicho";
            MySqlConnection conexion = new MySqlConnection(Variables.StringConection);
            try
            {
                conexion.Open();
                var data = image;
                using (var cmd = new MySqlCommand("insert into Post(ref_image,decripcion, username,image) VALUES('" + alias + "','" + descripcion + "', '" + alias1 + "',@image);",  conexion))
                {
                    cmd.Parameters.Add("@image", MySqlDbType.LongBlob).Value = data;
                    cmd.ExecuteNonQuery();
                }
                conexion.Close();
                return alias;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        public bool inserthashtag(String Hashtag,String imageId)
        {
            if (string.IsNullOrEmpty(Hashtag)) {
                return false;
            }

            MySqlConnection conexion = new MySqlConnection(Variables.StringConection);
            try
            {
                conexion.Open();
                String query = "insert into hashtag (tag) Values ('#"+Hashtag+"');";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.ExecuteNonQuery();
                
               
            }
            catch (Exception ex){}
            try
            {
                conexion.Close();
                conexion.Open();
                String query = "insert into post_hashtag(ref_image, tag) values('"+imageId+"', '#"+Hashtag+"'); ";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.ExecuteNonQuery();
                conexion.Close();

            }
            catch (Exception ex){}
            return true;
        }

        public MySqlDataReader GetPosts()
        {

            MySqlConnection conexion = new MySqlConnection(Variables.StringConection);
            try
            {
                conexion.Open();
                MySqlCommand comando = new MySqlCommand("select ref_image, decripcion, username, image from Post;", conexion);
                MySqlDataReader myreader = comando.ExecuteReader();
              
                return myreader;
            }
            catch (Exception ex)
            {
                return null;
            }

        }


        
        public MySqlDataReader GetHashtags(String imageId)
        {

            MySqlConnection conexion = new MySqlConnection(Variables.StringConection);
            try
            {
                conexion.Open();
                MySqlCommand comando = new MySqlCommand("select ref_image, tag from post_hashtag where ref_image = '"+imageId+"';", conexion);
                MySqlDataReader myreader = comando.ExecuteReader();

                return myreader;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
    }
}