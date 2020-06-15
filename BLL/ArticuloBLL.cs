using RegistroArticulo.Entidades;
using System.Collections.Concurrent;
using System.Linq.Expressions;
using System.Linq;
using RegistroArticulo.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegistroArticulo.BLL
{
    public class ArticuloBLL
    {
        public static bool Guardar(Articulos articulo)
        {
            if (!Existe(articulo.ArticuloId))
                return Insertar(articulo);
            else
                return Modificar(articulo);

        }

        private static bool Insertar(Articulos articulos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Articulos.Add(articulos);
                paso = contexto.SaveChanges() > 0;
            }
            catch
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        private static bool Modificar(Articulos articulos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(articulos).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                var articulo = contexto.Articulos.Find(id);

                if(articulo != null)
                {
                    contexto.Articulos.Remove(articulo);
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch 
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static Articulos Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Articulos articulos;

            try
            {
                articulos = contexto.Articulos.Find(id);
            }
            catch
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return articulos;
        }

        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Articulos.Any(e => e.ArticuloId == id);
            }
            catch
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return encontrado;
        }

        public static List<Articulos> GetList(Expression<Func<Articulos, bool>> criterio)
        {

        }
    }
}
