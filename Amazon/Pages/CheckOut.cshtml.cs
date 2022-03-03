using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amazon.Infrastucture;
using Amazon.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Amazon.Pages
{
    public class CheckOutModel : PageModel
    {

        private IAmazonRepository repo { get; set; }
        public Basket basket { get; set; }
        public string ReturnUrl { get; set; }

        public CheckOutModel(IAmazonRepository temp, Basket b)
        {
            repo = temp;
            basket = b;
        }


        public void OnGet(string returnurl)
        {
            ReturnUrl = ReturnUrl ?? "/";
        }

        public IActionResult OnPost(int bookId, string returnUrl)
        {
            Book p = repo.Books.FirstOrDefault(x => x.BookId == bookId);

            basket.AddItem(p, 1);

            return RedirectToPage(new { ReturnUrl = returnUrl });

        }

        public IActionResult OnPostremove(int bookId, string returnUrl)
        {
            basket.RemoveItem(basket.Items.First(x => x.Book.BookId == bookId).Book);

            return RedirectToPage(new { ReturnUrl = returnUrl });
        }
    }
}
