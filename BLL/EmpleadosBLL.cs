using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DAL;
using Entidades;

namespace BLL
{
    public class EmpleadosBLL
    {
        public static Empleados Guardar(Empleados nuevo)
        {
            Empleados creado = null;

            using (var db = new Repositorio<Empleados>())
            {
                creado = db.Guardar(nuevo);
            }
            return creado;
        }

        public static Empleados Buscar(Expression<Func<Empleados, bool>> tipo)
        {
            Empleados Result = null;
            using (var repositorio = new Repositorio<Empleados>())
            {
                Result = repositorio.Buscar(tipo);
                if (Result != null)
                    Result.RetencionList.Count();


            }
            return Result;
        }

        /*public static Empleados Buscando(int tipo)
        {
            Empleados Result = null;
            using (var repositorio = new ParcialDb())
            {
                Result = repositorio.Buscar(tipo);
                if (Result != null)
                    Result.RetencionList.Count();


            }
            return Result;
        }*/

        public static bool Mofidicar(Empleados criterio)
        {
            bool mod = false;
            using (var db = new Repositorio<Empleados>())
            {
                mod = db.Modificar(criterio);
            }

            return mod;

        }

        public static bool Eliminar(Empleados existente)
        {
            bool eliminado = false;
            using (var repositorio = new Repositorio<Empleados>())
            {
                eliminado = repositorio.Eliminar(existente);
            }

            return eliminado;

        }

        public static List<Empleados> GetListTodo()
        {
            List<Empleados> lista = null;
            using (var db = new Repositorio<Empleados>())
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


        public static List<Empleados> GetList(Expression<Func<Empleados, bool>> criterio)
        {
            List<Empleados> lista = null;
            using (var db = new Repositorio<Empleados>())
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
