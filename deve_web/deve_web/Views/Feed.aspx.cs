using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace deve_web.Views
{
    using deve_web.Acces;
    using Logic;
    using MySql.Data.MySqlClient;
    using System.IO;

    public partial class Feed : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (fup.HasFile)
            {
                int lenght = fup.PostedFile.ContentLength;
                byte[] pic = new byte[lenght];
                fup.PostedFile.InputStream.Read(pic, 0, lenght);
                FeedLogic fl = new FeedLogic();
                if (fl.LoadImage(pic, txtDescripcion.Text, TxtHashtag.Text)) {
                    Response.Write("<script LANGUAGE='JavaScript' >alert('¡Listo!')</script>");
                    return;
                }
                
                   

            }
                Response.Write("<script LANGUAGE='JavaScript' >alert('¡Algo salio mal! ')</script>");
            
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click1(object sender, EventArgs e)
        {


            MySqlConnection conexion = new MySqlConnection(Variables.StringConection);
            try
            {
                conexion.Open();

                MySqlCommand comando = new MySqlCommand("select image from Post where ref_image='2018’-‘10’-‘31’T’20’:’34’:’22.0759069-06:00wicho';", conexion);
                MySqlDataReader myreader = comando.ExecuteReader();
                myreader.Read();
                //String username = myreader["image"].ToString();


                byte[] image = (byte[])myreader["image"];
                int i=image.Length;
                i = i;
                string base64String = Convert.ToBase64String(image, 0, image.Length);
                imagen.ImageUrl = "data:image;base64," + Convert.ToBase64String(image);
            }
            catch (Exception ex){}
            

        }

        protected void Button4_Click(object sender, EventArgs e)
        {

        }

        protected void Button5_Click(object sender, EventArgs e)
        {

        }
    }
}