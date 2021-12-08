using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class Article
    {
        public int ArticleId { get; set; }
        public string Title { get; set; }
        public string Title_Body_text { get; set; }
        public string Video_url { get; set; }
        public string Body_text { get; set; }
        public string Img_url { get; set; }
        public DateTime Publication_time { get; set; }
        /*public Article(int ArticleId, string Title, string Body_text, string Img_url, DateTime Publication_time)
        {
            //this.ArticleId = ArticleId;
            this.Title = Title;
            this.Body_text = Body_text;
            this.Img_url = Img_url;
            this.Publication_time = Publication_time;
        }*/
    }
}
