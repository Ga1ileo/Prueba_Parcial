using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Prueba_Parcial.DAL;
using Prueba_Parcial.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Prueba_Parcial.BLL
{
    public class ArticuloBLL
    {
       public static bool Guardar(Articulo articulo)
        {
            if (!Existe(articulo.ArticuloId))

                return Insertar(articulo);
            else
                return Modificar(articulo);

        }

        private static bool Insertar(Articulo articulo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Articulo.Add(articulo);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;

            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        private static bool Modificar(Articulo articulo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {

                contexto.Entry(articulo).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;

            }
            catch (Exception)
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
                var auxProducto = contexto.Articulo.Find(id);
                if (auxProducto != null)
                {
                    contexto.Articulo.Remove(auxProducto);
                    paso = contexto.SaveChanges() > 0;

                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static Articulo Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Articulo articulo;

            try
            {
                articulo = contexto.Articulo.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return articulo;

        }

        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Articulo.Any(p=>p.ArticuloId == id);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return encontrado;

        }

        public static List<Articulo> GetList(Expression<Func<Articulo, bool>> expression)
        {
            List<Articulo> lista = new List<Articulo>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Articulo.Where(expression).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        } 
    }
}