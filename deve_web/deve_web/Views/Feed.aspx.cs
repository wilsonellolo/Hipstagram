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
        String username;
        protected void Page_Load(object sender, EventArgs e)
        {

            //select ref_image, decripcion, username, image from Post;
            MySqlConnection conexion = new MySqlConnection(Variables.StringConection);
            try
            {
                /*
                conexion.Open();
                MySqlCommand comando = new MySqlCommand("select ref_image, decripcion, username, image from Post;", conexion);
                MySqlDataReader myreader = comando.ExecuteReader();
                //myreader.Read();

                */
                FeedLogic fl = new FeedLogic();
                MySqlDataReader myreader = fl.posts();
                while (myreader.Read())
                {
                    Panel pa = new Panel();
                    pa.CssClass = "posters";
                    Label Username = new Label();
                    Username.CssClass = "users";
                    Username.Text= myreader.GetString(2);
                    pa.Controls.Add(Username);
                    //colocando imagen;
                    Image pic = new Image();
                    pic.CssClass = "image";


                    byte[] image = (byte[])myreader["image"];
                    string base64String = Convert.ToBase64String(image, 0, image.Length);
                    pic.ImageUrl = "data:image;base64," + Convert.ToBase64String(image);
                    pic.Width = 500;
                    pic.Height = 500;
                    pa.Controls.Add(pic);
                    //fin de colocar imagen
                    Label descripcion = new Label();
                    descripcion.CssClass = "description";
                    descripcion.Text = myreader.GetString(1);
                    pa.Controls.Add(descripcion);

                    form1.Controls.Add(pa);
                    

                }
                //String username = myreader["image"].ToString();


               /* byte[] image = (byte[])myreader["image"];
                string base64String = Convert.ToBase64String(image, 0, image.Length);
                imagen.ImageUrl = "data:image;base64," + Convert.ToBase64String(image);*/
            }
            catch (Exception ex) { }
            /******************************************/

        /*    for (int i = 0; i < 45; i++) {
                Label Username = new Label();
                Image pic = new Image();
                Button Like = new Button();
                Like.ID = "Like" + i;
                Label NoLike = new Label();
                Button Dislike = new Button();
                Label descripcion = new Label();
                Label hashtags = new Label();
                Button Comentar = new Button();
                username = "user" + i;
                Like.Text = "Like" + i;
                Like.ToolTip = "Like" + i;
                Like.Command += new CommandEventHandler(this.Like_click);
                form1.Controls.Add(Like);
                //pa.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF6230");
                Like.Click += new System.EventHandler(Like_click);


            }*/
        }

        protected void Like_click(object sender, EventArgs e) {

            Button bt = (Button)sender;
            Response.Write("<script LANGUAGE='JavaScript' >alert('Like a !"+bt.ID+" ')</script>");
            
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
                     Response.Redirect("Feed.aspx");
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

    

        }

        protected void Button4_Click(object sender, EventArgs e)
        {

        }

        protected void Button5_Click(object sender, EventArgs e)
        {

        }
    }
}