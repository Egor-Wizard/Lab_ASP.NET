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
            // ������������� ������ ���������
            Products = new List<Product>
            {
                new Product { Name = "���������", Price = 10.99m },
                new Product { Name = "���������", Price = 8.99m },
                new Product { Name = "���������", Price = 11.99m }
            };
        }

        public IActionResult OnPost()
        {
            if (Quantity <= 0 || Quantity > Products.Count)
            {
                ModelState.AddModelError(string.Empty, "������������ ���������� �������.");
                return Page();
            }

            // ��������� ������
            // ��������, �������� ������ ��� ������������ ������
            // ���������, ��� �� �� ����������� � �������� �������/������ � ��������, ����������� ������ ������

            return RedirectToPage("Confirmation");
        }
    }
}
