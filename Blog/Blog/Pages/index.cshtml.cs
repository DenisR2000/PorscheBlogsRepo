using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Blog.Pages
{
    public class IndexModel : PageModel
    {
        ArticleContext context;
        public IndexModel(ArticleContext context)
        {
            this.context = context;
        }
       /* public IEnumerable<ArticleLine> DisplayArticle { get; set; }*/
       public List<Article> DisplayArticle { get; set; }
        public IActionResult OnGet()
        {
             Article_Crud model = new Article_Crud();
             /*Article article = new Article(1, "New Porche", "Presentation a new panamera s4 Turbo!", "https://presskit.porsche.de/models/assets/images/7/Slider_SEHybr_02_summary-98ce0cb7.jpg", new DateTime());
             model.AddArticle(article);
             DisplayArticle = model.line;*/

            DisplayArticle = context.Articles.ToList();
            return Page();
        }
    }
}
