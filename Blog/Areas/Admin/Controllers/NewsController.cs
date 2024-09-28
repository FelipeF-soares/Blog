using Blog.Data.Repository.Interfaces;
using Blog.Models;
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
    public IActionResult Add()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Add(News news)
    {
        news.DatePost = DateTime.Now;
        repository.Add(news);
        repository.SaveChange();
        return RedirectToAction("Index");
    }
    public IActionResult Update(int id)
    {
        var news = repository.GetById(id);
        return View(news);
    }
    [HttpPost]
    public IActionResult Update(News update)
    {
        update.DatePost = DateTime.Now;
        repository.Update(update);
        repository.SaveChange();
        return RedirectToAction("Index");
    }
    public IActionResult Delete(int id)
    {
        var news = repository.GetById(id);
        repository.Remove(news);
        repository.SaveChange();
        return RedirectToAction("Index");
    }
}
