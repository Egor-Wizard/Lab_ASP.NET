using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaOrderApp.Models;
using System.Collections.Generic;

namespace PizzaOrderApp.Pages
{
    public class ConfirmationModel : PageModel
    {
        public List<Product> Products { get; set; }

        public void OnGet(List<Product> products)
        {
            Products = products;
        }
    }
}
