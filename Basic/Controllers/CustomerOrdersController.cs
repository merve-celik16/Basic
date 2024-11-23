using Basic.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basic.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            Customer customer = new()
            {
                Id = 1,
                FirstName = "Merve",
                LastName = "Çelik",
                Email = "mervedursunn@gmail.com"
            };
           

            List<Order> orders = new()
            {
                new(1, "Tablet", 500, 1),
                new(2, "Kulaklık", 300, 2),
                new(3, "Saat", 1000, 1),
                new(4, "Çorap",250 , 12)
            };

            var viewModel = new CustomerViewModel
            {
                Customer = customer,
               
                Orders = orders
            };

            return View(viewModel);
        }
    }
}