using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DAL;
using Entidades;

namespace BLL
{
    public class RetencionesBLL
    {
        public static Entidades.Retenciones Guardar(Retenciones nuevo)
        {
            Retenciones creado = null;

            using (var db = new Repositorio<Retenciones>())
            {
                creado = db.Guardar(nuevo);
            }
            return creado;
        }

        public static Retenciones Buscar(Expression<Func<Retenciones, bool>> tipo)
        {
            Retenciones Result = null;
            using (var repositorio = new Repositorio<Retenciones>())
            {
                Result = repositorio.Buscar(tipo);
                if (Result != null)
                    Result.EmpleadosList.Count();
            }

            return Result;
        }

        public static bool Mofidicar(Retenciones criterio)
        {
            bool mod = false;
            using (var db = new Repositorio<Retenciones>())
            {
                mod = db.Modificar(criterio);
            }

            return mod;

        }

        public static bool Eliminar(Retenciones existente)
        {
            bool eliminado = false;
            using (var repositorio = new Repositorio<Retenciones>())
            {
                eliminado = repositorio.Eliminar(existente);
            }

            return eliminado;

        }

        public static List<Retenciones> GetListTodo()
        {
            List<Retenciones> lista = null;
            using (var db = new Repositorio<Retenciones>())
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

        public static List<Retenciones> GetList(Expression<Func<Retenciones, bool>> criterio)
        {
            List<Retenciones> lista = null;
            using (var db = new Repositorio<Retenciones>())
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

