using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TareaGenero.Data;

namespace TareaGenero.BLL
{
    public class RepositorioBase<T> : IDisposable, IRepository<T> where T : class
    {
        internal Contexto _contexto;

        public RepositorioBase(Contexto contexto)
        {
            _contexto = contexto;
        }
        public RepositorioBase()
        {
            _contexto = new Contexto();
        }


        public virtual bool Guardar(T entity)
        {
            bool paso = false;

            try
            {
                if (_contexto.Set<T>().Add(entity) != null)
                {
                    _contexto.SaveChanges();
                    paso = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public virtual void Dispose()
        {
            _contexto.Dispose();
        }

    }
}