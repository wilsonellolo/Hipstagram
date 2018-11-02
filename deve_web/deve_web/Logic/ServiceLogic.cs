using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace deve_web.Logic
{
    public class ServiceLogic
    {
        public bool  IsSensitiveImage(String image){
            string url = "https://servicio-imagen.appspot.com/?image="+ image;
            WebRequest request = WebRequest.Create(url);
            WebResponse ws = request.GetResponse();
            string o;
            String[] vector;
            using (var stream = ws.GetResponseStream())

            using (var reader = new StreamReader(stream))
            {
                o = reader.ReadToEnd();
                vector= o.Split(',');
                
            }
            if (vector[0].Contains("1"))
            {
                return true;
            }
            else  {
                return false;
            }
           
        }

        public bool IsSensitiHashtags(String Hashtags)
        {
            Hashtags = Hashtags.Replace("#", " ");
            string url = "https://servicio-hashtag.appspot.com/?wd=" + Hashtags;
            WebRequest request = WebRequest.Create(url);
            WebResponse ws = request.GetResponse();
            string o;
            using (var stream = ws.GetResponseStream())

            using (var reader = new StreamReader(stream))
            {
                o = reader.ReadToEnd();
                if (o.Contains("1"))
                {
                    return true;
                }
                else {
                    return false;
                }
            }
            

           

        }
    }
}