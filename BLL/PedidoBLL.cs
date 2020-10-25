using Prueba_Parcial.Models;
using Prueba_Parcial.DAL;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace Prueba_Parcial.BLL
{
    public class PedidoBLL
    {
        public static bool Guardar(Pedido pedido)
        {
            if (!Existe(pedido.PedidoId))

                return Insertar(pedido);
            else
                return Modificar(pedido);
        }

        private static bool Insertar(Pedido pedido)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Pedido.Add(pedido);
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

        private static bool Modificar(Pedido pedido)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {

                contexto.Entry(pedido).State = EntityState.Modified;
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
                var auxPedido = contexto.Pedido.Find(id);
                if (auxPedido != null)
                {
                    contexto.Pedido.Remove(auxPedido);
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

        public static Pedido Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Pedido pedido;

            try
            {
                pedido = contexto.Pedido.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return pedido;

        }

        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Pedido.Any(p=>p.PedidoId == id);

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

        public static List<Pedido> GetList(Expression<Func<Pedido, bool>> expression)
        {
            List<Pedido> lista = new List<Pedido>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Pedido.Where(expression).ToList();
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