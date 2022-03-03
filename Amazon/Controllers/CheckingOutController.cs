using Amazon.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon.Controllers
{
    public class CheckingOutController : Controller
    {
        private ICheckingOutRepository repo { get; set; }
        private Basket basket { get; set; }
        public CheckingOutController (ICheckingOutRepository temp, Basket b)
        {
            repo = temp;
            basket = b;
        }

        [HttpGet]
        public IActionResult Checkout()
        {
            return View(new CheckingOut());
        }
        [HttpPost]
        public IActionResult Checkout(CheckingOut checkingOut)
        {
            if (basket.Items.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry, your basket is empty!");
            }
            if (ModelState.IsValid)
            {
                checkingOut.Lines = basket.Items.ToArray();
                repo.SaveCheckout(checkingOut);
                basket.ClearBasket();

                return RedirectToPage("/CheckoutCompleted");
            }
            else
            {
                return View();
            }
        }
    }
}
