using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Blog.Pages
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Article Article { get; set; }
        ArticleContext context;
        public CreateModel(ArticleContext context)
        {
            this.context = context;
        }
        public IActionResult OnGet()
        {
            return Page();
        }
        public async Task< IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            context.Add(Article);
            await context.SaveChangesAsync();
            return RedirectToPage("Page");
        }
    }
}
