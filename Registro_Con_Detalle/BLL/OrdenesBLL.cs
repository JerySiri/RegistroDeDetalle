using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registro_Con_Detalle.Entidades;
using Registro_Con_Detalle.DAL;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Registro_Con_Detalle.BLL
{
    class OrdenesBLL
    {
        public static bool Guardar(Ordenes orden)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                if (contexto.Ordenes.Add(orden) != null)
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

        public static bool Modificar(Ordenes orden)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Database.ExecuteSqlRaw($"Delete FROM OrdenesDetalle Where OrdenesId = {orden.OrdenesId}");

                foreach (var anterior in orden.OrdenesDetalles)
                {
                    contexto.Entry(anterior).State = EntityState.Added;
                }
                contexto.Entry(orden).State = EntityState.Added;
                paso = (contexto.SaveChanges() > 0);
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
                var eliminar = contexto.Ordenes.Find(id);
                contexto.Entry(eliminar).State = EntityState.Deleted;

                paso = (contexto.SaveChanges() > 0);
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

        public static Ordenes Buscar(int id)
        {
            Ordenes orden = new Ordenes();
            Contexto contexto = new Contexto();

            try
            {
                orden = contexto.Ordenes.Include(o => o.OrdenesDetalles).Where(p => p.OrdenesId == id).SingleOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return orden;
        }

        public static List<Ordenes> GetList(Expression<Func<Ordenes, bool>> orden)
        {
            List<Ordenes> lista = new List<Ordenes>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Ordenes.Where(orden).ToList();
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
