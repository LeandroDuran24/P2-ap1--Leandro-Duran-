using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DAL
{
   public interface IRepository <TEntity>:IDisposable where TEntity:class
    {
        TEntity Guardar(TEntity criterio);
        bool Eliminar(TEntity criterio);
        bool Modificar(TEntity criterio);
        TEntity Buscar(Expression<Func<TEntity, bool>> criterio);
        List<TEntity> GetList(Expression<Func<TEntity, bool>> criterio);
        List<TEntity> GetListTodo();
    }
}
