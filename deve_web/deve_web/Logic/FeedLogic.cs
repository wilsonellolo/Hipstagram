using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace deve_web.Logic
{
    using Acces;
    public class FeedLogic
    {
        public bool LoadImage(byte[] pic, String descripcion, String hashtags)
        {
            DivAndInsertHashtag(hashtags);
            crud crud = new crud();
            if (crud.IsInserted(pic, descripcion))
            {

                return true;
            }
            else {
                return false;
            }



        }

        private void  DivAndInsertHashtag(String Hashtag){
            Hashtag = Hashtag.Replace(" ", "");
            string[] hashtags = Hashtag.Split('#');
            crud crud = new crud();
            foreach (String h in hashtags) {
                crud.inserthashtag(h);
            }
            
        }
    }
}