using Blog.Data.Repository.Interfaces;
using Blog.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Blog.Areas.Customer.Controllers;
[Area("Customer")]
public class HomeController : Controller
{
    private readonly INewsRepository repository;

    public HomeController(INewsRepository repository)
    {
        this.repository = repository;
    }

    public IActionResult Index()
    {
        var news = repository.GetAll();
        return View(news.ToList());
    }

}
