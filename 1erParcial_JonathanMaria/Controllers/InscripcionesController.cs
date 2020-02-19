using _1erParcial_JonathanMaria.Data;
using _1erParcial_JonathanMaria.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1erParcial_JonathanMaria.Controllers
{
    public class InscripcionesController
    {

        public bool Insertar(Inscripciones Inscripcion)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            if(Inscripcion.InscripcionId == 0)
            {

                paso = Guardar(Inscripcion);
            }
            else
            {

                paso = Modificar(Inscripcion);
            }

            return paso;
        }

        public static bool Guardar(Inscripciones Inscripcion)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {

                contexto.Inscripciones.Add(Inscripcion);
                paso = contexto.SaveChanges() > 0;
            }
            catch(Exception)
            {

                throw;
            }
            finally
            {

                contexto.Dispose();
            }

            return paso;
        }

        public static bool Modificar(Inscripciones Inscripcion)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {

                contexto.Entry(Inscripcion).State = EntityState.Modified;
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

        public bool Eliminar(int Id)
        {

            bool paso = false;
            Contexto contexto = new Contexto();
            Inscripciones Inscripcion = contexto.Inscripciones.Find(Id);

            try
            {

                contexto.Entry(Inscripcion).State = EntityState.Deleted;
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

        public Inscripciones Buscar(int Id)
        {

            Contexto contexto = new Contexto();
            Inscripciones Inscripcion = new Inscripciones();

            try
            {

                Inscripcion = contexto.Inscripciones.Find(Id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

                contexto.Dispose();
            }

            return Inscripcion;
        }
    }
}
