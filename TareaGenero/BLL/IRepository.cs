using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace TareaGenero.BLL
{
    public interface IRepository<T> where T : class
    {
   
        bool Guardar(T entity);
      
    }
}
