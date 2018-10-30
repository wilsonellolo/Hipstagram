using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace deve_web.Logic
{
    using Acces;
    public class FeedLogic
    {
        public bool LoadImage(byte[] pic,String descripcion,String hashtags)
        {
            crud crud = new crud();

            return crud.IsInserted(pic, descripcion);
                            
           
        }
    }
}