using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Blog.Pages
{
    public class DopInfoModel : PageModel
    {
        ArticleContext context;
        public DopInfoModel(ArticleContext context)
        {
            this.context = context;
        }
        public Article FindForID(int id)
        {
            Article article = context.Articles.Find(id);
            return article;
        }
        public Article DisplayArticle { get; set; }
        public IActionResult OnGet(int id)
        {
            DisplayArticle = FindForID(id);
            return Page();
        }
    }
}
