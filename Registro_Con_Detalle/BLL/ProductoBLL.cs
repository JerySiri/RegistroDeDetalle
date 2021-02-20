using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registro_Con_Detalle.Entidades;
using Registro_Con_Detalle.DAL;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Registro_Con_Detalle.BLL
{
    class ProductoBLL
    {
        private static bool Insertar(Producto producto)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Producto.Add(producto);
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

        public static bool Modificar(Producto producto)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(producto).State = EntityState.Modified;
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

        private static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Producto.Any(e => e.ProductoId == id);
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


        public static bool ExisteDescripcion(string descripcion)
        {

            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Producto.Any(e => e.Nombre == descripcion);
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

        public static bool Guardar(Producto producto)
        {

            if (!Existe(producto.ProductoId))
                return Insertar(producto);
            else
                return Modificar(producto);

        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                var rol = contexto.Producto.Find(id);

                if (rol != null)
                {
                    contexto.Producto.Remove(rol);
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
        public static List<Producto> GetList(Expression<Func<Producto, bool>> criterio)
        {
            List<Producto> Lista = new List<Producto>();
            Contexto contexto = new Contexto();

            try
            {

                Lista = contexto.Producto.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return Lista;
        }
        public static List<Producto> GetRoles()
        {
            List<Producto> lista = new List<Producto>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Producto.ToList();
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


        public static Producto Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Producto producto;

            try
            {
                producto = contexto.Producto.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return producto;
        }

    }
}
