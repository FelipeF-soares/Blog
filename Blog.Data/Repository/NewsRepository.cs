using Blog.Data.DataContext;
using Blog.Data.Repository.Interfaces;
using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Repository;

public class NewsRepository : INewsRepository
{
    private readonly NewsDataContext context;

    public NewsRepository(NewsDataContext context)
    {
        this.context = context;
    }
    public void Add(News entity)
    {
        context.News.Add(entity);
    }
    public void Update(News entity)
    {
        context.News.Update(entity);
    }
    public void Remove(News entity)
    {
        context.News.Remove(entity);
    }
    public News GetById(int id)
    {
        var news = context.News.FirstOrDefault(x => x.Id == id);
        return news;
    }
    public IEnumerable<News> GetAll()
    {
        var news = context.News;
        return news;
    }
    public bool SaveChange()
    {
       return (context.SaveChanges() > 0);
    }
}
