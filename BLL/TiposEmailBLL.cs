using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DAL;
using Entidades;

namespace BLL
{
    public class TiposEmailBLL
    {
        public static Entidades.TiposEmail Guardar(Entidades.TiposEmail nuevo)
        {
            TiposEmail creado = null;

            using (var db = new Repositorio<TiposEmail>())
            {
                creado = db.Guardar(nuevo);
            }
            return creado;
        }

        public static TiposEmail Buscar(Expression<Func<TiposEmail, bool>> tipo)
        {
            TiposEmail Result = null;
            using (var repoitorio = new Repositorio<TiposEmail>())
            {
                Result = repoitorio.Buscar(tipo);
            }

            return Result;
        }

        public static bool Mofidicar(TiposEmail criterio)
        {
            bool mod = false;
            using (var db = new Repositorio<TiposEmail>())
            {
                mod = db.Modificar(criterio);
            }

            return mod;

        }

        public static bool Eliminar(TiposEmail existente)
        {
            bool eliminado = false;
            using (var repositorio = new Repositorio<TiposEmail>())
            {
                eliminado = repositorio.Eliminar(existente);
            }

            return eliminado;

        }


        public static List<TiposEmail> GetListTodo()
        {
            List<TiposEmail> lista = null;
            using (var db = new Repositorio<TiposEmail>())
            {
                try
                {
                    lista = db.GetListTodo();
                }
                catch (Exception)
                {

                    throw;
                }
                return lista;
            }
        }


        public static List<TiposEmail> GetList(Expression<Func<TiposEmail, bool>> criterio)
        {
            List<TiposEmail> lista = null;
            using (var db = new Repositorio<TiposEmail>())
            {
                try
                {
                    lista = db.GetList(criterio).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return lista;

        }
    }
}
