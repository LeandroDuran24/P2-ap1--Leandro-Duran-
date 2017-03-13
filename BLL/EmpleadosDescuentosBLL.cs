using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DAL;
using Entidades;

namespace BLL
{
    public class EmpleadosDescuentosBLL
    {
        public static EmpleadosRetenciones Guardar(EmpleadosRetenciones nuevo)
        {
            EmpleadosRetenciones creado = null;

            using (var db = new Repositorio<EmpleadosRetenciones>())
            {
                creado = db.Guardar(nuevo);
            }
            return creado;
        }

        public static EmpleadosRetenciones Buscar(Expression<Func<EmpleadosRetenciones, bool>> tipo)
        {
            EmpleadosRetenciones Result = null;
            using (var repoitorio = new Repositorio<EmpleadosRetenciones>())
            {
                Result = repoitorio.Buscar(tipo);
            }

            return Result;
        }

        public static bool Mofidicar(EmpleadosRetenciones criterio)
        {
            bool mod = false;
            using (var db = new Repositorio<EmpleadosRetenciones>())
            {
                mod = db.Modificar(criterio);
            }

            return mod;

        }

        public static bool Eliminar(EmpleadosRetenciones existente)
        {
            bool eliminado = false;
            using (var repositorio = new Repositorio<EmpleadosRetenciones>())
            {
                eliminado = repositorio.Eliminar(existente);
            }

            return eliminado;

        }

        public static List<EmpleadosRetenciones> GetListTodo()
        {
            List<EmpleadosRetenciones> lista = null;
            using (var db = new Repositorio<EmpleadosRetenciones>())
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


        public static List<EmpleadosRetenciones> GetList(Expression<Func<EmpleadosRetenciones, bool>> criterio)
        {
            List<EmpleadosRetenciones> lista = null;
            using (var db = new Repositorio<EmpleadosRetenciones>())
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
