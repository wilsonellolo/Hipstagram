using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace deve_web.Views
{
    using Logic;
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Sesion.logueado) {
                if (!string.IsNullOrEmpty(Sesion.username)) { 
                Response.Redirect("Feed.aspx");
                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SingUpLogic sgu = new SingUpLogic();

            if (sgu.InsertUser(txtAlias.Text, txtNombre.Text, txtApellido.Text, txtNacimientoDate.Text, txtcontrasena.Text, txtMail.Text, "1"))
            {
                Response.Write("<script LANGUAGE='JavaScript' >alert('Tu registro fue exitoso.')</script>");
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