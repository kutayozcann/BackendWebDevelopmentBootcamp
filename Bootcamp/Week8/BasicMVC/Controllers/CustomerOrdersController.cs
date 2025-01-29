using BasicMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasicMVC.Controllers;

public class CustomerOrdersController : Controller
{
    public IActionResult Index()
    {
        var customer = new Customer()
        {
            Id = 1,
            FirstName = "John",
            LastName = "Doe",
            Email = "johndoe@gmail.com"
        };

        var orders = new List<Order>()
        {
            new Order() { Id = 1, Price = 350, Quantity = 10, ProductName = "T-Shirt" },
            new Order() { Id = 2, Price = 700, Quantity = 20, ProductName = "Jacket" },
            new Order() { Id = 3, Price = 1500, Quantity = 13, ProductName = "Sneaker" }
        };

        var viewModel = new CustomerOrderViewModel()
        {
            Customer = customer,
            Orders = orders
        };

        return View(viewModel);
    }
}