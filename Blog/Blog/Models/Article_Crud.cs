using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class Article_Crud
    {
        ArticleContext context;
        public Article_Crud()
        {}
        public Article_Crud(ArticleContext context)
        {
            this.context = context;
        }

        public List<ArticleLine> list = new List<ArticleLine>();
        public void AddArticle(Article article)
        {
            list.Add(new ArticleLine
            { 
                Article = article
            });
        }
        public Article FindForId(int id)
        {
            Article article = context.Articles.FirstOrDefault(x => x.ArticleId == id);
            return article;
        }
        public IEnumerable<ArticleLine> line => list;
    }
    public class ArticleLine
    {
        public Article Article { get; set; }
    }
}
