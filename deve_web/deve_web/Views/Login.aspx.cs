using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace deve_web.Views
{
    using Logic;
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       

      

        protected void btnEntrar(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            LogInLogic lig = new LogInLogic();
            if (lig.IsUser(txtAlias.Text, txtPassword.Text))
            {
                Response.Redirect("Feed.aspx");
            }
            else {
                Response.Write("<script LANGUAGE='JavaScript' >alert('¡Algo salio mal! Revisa de nuevo tus datos.')</script>");
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registro.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}