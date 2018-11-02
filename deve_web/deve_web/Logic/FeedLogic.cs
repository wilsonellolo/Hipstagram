using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace deve_web.Logic
{
    using Acces;
    public class FeedLogic
    {
        public bool LoadImage(byte[] pic, String descripcion, String hashtags)
        {
            
            crud crud = new crud();
            String imageId;
            imageId = crud.IsInserted(pic, descripcion);
            if (!string.IsNullOrEmpty(imageId))
            {
                DivAndInsertHashtag(hashtags, imageId);
                return true;
            }
            else {
                return false;
            }

        }

        private void  DivAndInsertHashtag(String Hashtag, String imageId)
        {
          Hashtag = Hashtag.Replace(" ", "");
            string[] hashtags = Hashtag.Split('#');
            crud crud = new crud();
            for (int i = 0; i < hashtags.Length; i++) {
                crud.inserthashtag(hashtags[i],imageId);
            }
            
        }

        public MySqlDataReader posts() {
            crud crud = new crud();
            return crud.GetPosts();
        }
        public MySqlDataReader HashtagsR(String ImageId)
        {
            crud crud = new crud();
            return crud.GetHashtags(ImageId);
        }
    }
}