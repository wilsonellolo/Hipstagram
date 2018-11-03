﻿using deve_web.Acces;
using deve_web.Logic;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace deve_web.Views
{
    public partial class Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Sesion.search)) {
                Response.Redirect("Feed.aspx");
            }
           

            MySqlConnection conexion = new MySqlConnection(Variables.StringConection);
            try
            {
                FeedLogic fl = new FeedLogic();
                crud crr = new crud();
                MySqlDataReader myreader = crr.GetPostsSearch(Sesion.search);
             
                short count = 0;
                while (myreader.Read())
                {
                    Panel pa = new Panel();
                    pa.CssClass = "posters";
                    Label Username = new Label();
                    Username.CssClass = "users";
                    Username.Text = myreader.GetString(2);
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
                    descripcion.Text = "<BR>" + myreader.GetString(1);
                    pa.Controls.Add(descripcion);

                    //colocando Hashtags
                    Label hashtgas = new Label();
                    hashtgas.ForeColor = System.Drawing.Color.Blue;
                    MySqlDataReader RH = fl.HashtagsR(myreader.GetString(0));
                    String auxHashtags = string.Empty;
                    while (RH.Read())
                    {
                        auxHashtags += RH.GetString(1) + " ";
                    }
                    hashtgas.Text = "<BR><BR>" + auxHashtags;
                    pa.Controls.Add(hashtgas);

                    RH.Close();

                    //Like y disliek
                    Button btnDislike = new Button();
                    btnDislike.Width = 10;
                    btnDislike.Text = "↓";
                    btnDislike.ToolTip = myreader.GetString(0);
                    btnDislike.Click += new EventHandler(this.Dislike_click);
                    btnDislike.CssClass = "dislike";
                    pa.Controls.Add(btnDislike);

                    Label LikeCount = new Label();
                    LikeCount.CssClass = "likeCount";
                    LikeCount.Width = 10;
                    crud cr = new crud();
                    String count_like = cr.getLikes(myreader.GetString(0));
                    if (!string.IsNullOrEmpty(count_like))
                    {
                        LikeCount.Text = count_like;
                    }
                    else
                    {
                        LikeCount.Text = "0";
                    }
                    pa.Controls.Add(LikeCount);


                    Button btnLike = new Button();
                    btnLike.Width = 11;
                    btnLike.Text = "↑";
                    btnLike.CssClass = "like";
                    btnLike.ToolTip = myreader.GetString(0) + "#";
                    btnLike.Click += new EventHandler(this.Like_click);
                    pa.Controls.Add(btnLike);

                    //Comentarios
                    Label lbl = new Label();
                    lbl.CssClass = "comentarios";
                    lbl.Text = "<BR><BR>" + "Ingrese un comentario:";
                    pa.Controls.Add(lbl);

                    TextBox comment = new TextBox();
                    comment.TextMode = TextBoxMode.MultiLine;
                    comment.Width = 534;
                    comment.Height = 100;
                    comment.BackColor = System.Drawing.Color.GhostWhite;
                    comment.ToolTip = "Ingrese un comentario sobre la imagen.";
                    comment.TabIndex = count;
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
                    btnSeeComment.Width = 110;
                    btnSeeComment.BackColor = System.Drawing.Color.DodgerBlue;
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
        protected void hacer(String a) { }

        protected void Like_click(object sender, EventArgs e)
        {
            //Response.Write("<script LANGUAGE='JavaScript' >alert('¡Voto positivo!')</script>");
            Button bt = (Button)sender;
            crud cr = new crud();
            cr.inserRank(Sesion.username, bt.ToolTip.Replace("#", ""), "1");
            Response.Redirect("Feed.aspx");
        }
        protected void Dislike_click(object sender, EventArgs e)
        {
            //Response.Write("<script LANGUAGE='JavaScript' >alert('¡Voto Negativo!')</script>");
            Button bt = (Button)sender;
            crud cr = new crud();
            cr.inserRank(Sesion.username, bt.ToolTip, "-1");
            Response.Redirect("Feed.aspx");
        }

       


        protected void LinkSalir(object sender, EventArgs e)
        {
            Sesion.logueado = false;
            Sesion.username = null;
            Response.Redirect("Login.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Feed.aspx");
        }
    }
}