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
            
            MySqlConnection conexion = new MySqlConnection(Variables.StringConection);
            try
            {
                FeedLogic fl = new FeedLogic();
                MySqlDataReader myreader = fl.posts();
                short count = 0;
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
                    descripcion.Text = "<BR>"+ myreader.GetString(1);
                    pa.Controls.Add(descripcion);
                    
                    //colocando Hashtags
                    Label hashtgas = new Label();
                    hashtgas.ForeColor = System.Drawing.Color.Blue;
                    MySqlDataReader RH = fl.HashtagsR(myreader.GetString(0));
                    String auxHashtags=string.Empty;
                    while (RH.Read()) {
                        auxHashtags +=RH.GetString(1)+" ";
                    }
                    hashtgas.Text = "<BR><BR>" + auxHashtags;
                    pa.Controls.Add(hashtgas) ;

                    //Comentarios
                    Label lbl = new Label();
                    lbl.CssClass = "comentarios";
                    lbl.Text = "<BR><BR>" + "Ingrese un comentario:";
                    pa.Controls.Add(lbl);

                    TextBox comment = new TextBox();
                    comment.TextMode = TextBoxMode.MultiLine;
                    comment.Width = 534;
                    comment.Height=100;
                    comment.BackColor = System.Drawing.Color.GhostWhite;
                    comment.ToolTip = "Ingrese un comentario sobre la imagen.";
                    comment.TabIndex =count;                    
                    pa.Controls.Add(comment);

                    Button btnComment = new Button();
                    btnComment.BackColor = System.Drawing.Color.Gainsboro;
                    btnComment.Text = "Comentar";
                    pa.Controls.Add(btnComment);

                    Label space = new Label();
                    space.Text = "<BR><BR>";
                    pa.Controls.Add(space);

                    Button btnSeeComment = new Button();
                    btnSeeComment.CssClass = "right";
                    btnSeeComment.Width=110;
                    btnSeeComment.BackColor=System.Drawing.Color.DodgerBlue;
                    btnSeeComment.Text = "Comentarios";
                    pa.Controls.Add(btnSeeComment);

                    //Agregando panel
                    form1.Controls.Add(pa);
                    count++;
                }
                myreader = null;
                myreader.Close();
                
            }
            catch (Exception ex) { }
          
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