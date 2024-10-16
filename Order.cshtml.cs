using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaOrderApp.Models;

namespace PizzaOrderApp.Pages
{
    public class OrderModel : PageModel
    {
        [BindProperty]
        public int Quantity { get; set; }

        [BindProperty]
        public List<Product> Products { get; set; }

        public void OnGet()
        {
            // Инициализация списка продуктов
            Products = new List<Product>
            {
                new Product { Name = "Пепперони", Price = 10.99m },
                new Product { Name = "Маргарита", Price = 8.99m },
                new Product { Name = "Гавайская", Price = 11.99m }
            };
        }

        public IActionResult OnPost()
        {
            if (Quantity <= 0 || Quantity > Products.Count)
            {
                ModelState.AddModelError(string.Empty, "Некорректное количество товаров.");
                return Page();
            }

            // Обработка заказа
            // Например, добавьте логику для формирования заказа
            // Убедитесь, что вы не обращаетесь к элементу массива/списка с индексом, превышающим размер списка

            return RedirectToPage("Confirmation");
        }
    }
}
