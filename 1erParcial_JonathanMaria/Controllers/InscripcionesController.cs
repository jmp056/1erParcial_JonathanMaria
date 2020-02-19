﻿using _1erParcial_JonathanMaria.Data;
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
    }
}