using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace deve_web.Models
{
    public class Publicacion
    {
        public String id_publicacion { get; set; }
        public String descripicion { get; set; }
        public String imagen { get; set; }
        public int like { get; set; }
        public List<Comentario> comentarios { get; set; }
        public String Hashtag { get; set; }

        public Publicacion() {
            comentarios = new List<Comentario>();           
        }
    }
}