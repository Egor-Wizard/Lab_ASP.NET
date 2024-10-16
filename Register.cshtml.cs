using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaOrderApp.Models;

namespace PizzaOrderApp.Pages
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public User User { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (User.Age > 16)
            {
                return RedirectToPage("Order");
            }

            return Page();
        }
    }
}
