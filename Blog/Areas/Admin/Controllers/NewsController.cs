using Blog.Data.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Areas.Admin.Controllers;
[Area("Admin")]
public class NewsController : Controller
{
    private readonly INewsRepository repository;

    public NewsController(INewsRepository repository)
    {
        this.repository = repository;
    }
    public IActionResult Index()
    {
        var news = repository.GetAll();
        return View(news.ToList());
    }
}
