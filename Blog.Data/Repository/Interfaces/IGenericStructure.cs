using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Repository.Interfaces;

public interface IGenericStructure<T> where T : class
{
    void Add(T entity);
    void Remove(T entity);
    void Update(T entity);
    bool SaveChange();
}
