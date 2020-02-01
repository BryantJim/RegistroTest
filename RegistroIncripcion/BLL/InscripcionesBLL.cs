using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using RegistroIncripcion.Entidades;
using RegistroIncripcion.DAL;
using System.Linq.Expressions;
using System.Linq;

namespace RegistroIncripcion.BLL
{
    public class InscripcionesBLL
    {
        public static bool Guardar(Inscripciones incripcion)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                if (db.Inscripciones.Add(incripcion) != null)
                    paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool Modificar(Inscripciones incripcion)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(incripcion).State = EntityState.Modified;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool Eliminar(int Id)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                var Eliminar = db.Inscripciones.Find(Id);
                db.Entry(Eliminar).State = EntityState.Deleted;

                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static Inscripciones Buscar(int Id)
        {
            Contexto db = new Contexto();
            Inscripciones incripcion = new Inscripciones();

            try
            {
                incripcion = db.Inscripciones.Find(Id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return incripcion;
        }

        public static List<Inscripciones> GetList(Expression<Func<Inscripciones, bool>> incripcion)
        {
            List<Inscripciones> Lista = new List<Inscripciones>();
            Contexto db = new Contexto();

            try
            {
                Lista = db.Inscripciones.Where(incripcion).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Lista;
        }
    }
}
