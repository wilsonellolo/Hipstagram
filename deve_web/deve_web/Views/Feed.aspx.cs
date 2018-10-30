using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace deve_web.Views
{
    using Logic;
    public partial class Feed : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
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

        protected void LinkButton2_Click(object sender, EventArgs e)
        {

        }

        protected void Button_Clic(object sender, EventArgs e)
        {

        }
    }
}