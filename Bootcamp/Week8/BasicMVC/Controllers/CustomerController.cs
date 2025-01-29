using BasicMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasicMVC.Controllers;

public class CustomerController : Controller
{
    public IActionResult Index()
    {
        var customer = new Customer
        {
            Id = 1,
            FirstName = "John",
            LastName = "Doe",
            Email = "johndoe@gmail.com"
        };

        var viewModel = new CustomerViewModel
        {
            Customer = customer,
            WelcomeMessage = "Welcome to our customer portal!"
        };
        return View(viewModel);
    }
}