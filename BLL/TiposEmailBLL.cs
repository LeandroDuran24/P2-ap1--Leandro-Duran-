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
        public static Entidades.TiposEmails Guardar(Entidades.TiposEmails nuevo)
        {
            TiposEmails creado = null;

            using (var db = new Repositorio<TiposEmails>())
            {
                creado = db.Guardar(nuevo);
            }
            return creado;
        }

        public static TiposEmails Buscar(Expression<Func<TiposEmails, bool>> tipo)
        {
            TiposEmails Result = null;
            using (var repoitorio = new Repositorio<TiposEmails>())
            {
                Result = repoitorio.Buscar(tipo);
            }

            return Result;
        }

        public static bool Mofidicar(TiposEmails criterio)
        {
            bool mod = false;
            using (var db = new Repositorio<TiposEmails>())
            {
                mod = db.Modificar(criterio);
            }

            return mod;

        }

        public static bool Eliminar(TiposEmails existente)
        {
            bool eliminado = false;
            using (var repositorio = new Repositorio<TiposEmails>())
            {
                eliminado = repositorio.Eliminar(existente);
            }

            return eliminado;

        }


        public static List<TiposEmails> GetListTodo()
        {
            List<TiposEmails> lista = null;
            using (var db = new Repositorio<TiposEmails>())
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


        public static List<TiposEmails> GetList(Expression<Func<TiposEmails, bool>> criterio)
        {
            List<TiposEmails> lista = null;
            using (var db = new Repositorio<TiposEmails>())
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
