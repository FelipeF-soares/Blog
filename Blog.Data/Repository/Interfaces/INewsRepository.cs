using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Repository.Interfaces;

public interface INewsRepository : IGenericStructure<News>
{
    IEnumerable<News> GetAll();
    News GetById(int id);
}
