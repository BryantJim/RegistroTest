﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RegistroIncripcion.Entidades
{
    public class Estudiantes
    {
        public int PersonaId { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Telefono { get; set; }
        public String Cedula { get; set; }
        public String Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Balance { get; set; }

        public Estudiantes()
        {
            PersonaId = 0;
            Nombre = string.Empty;
            Apellido = string.Empty;
            Telefono = string.Empty;
            Cedula = string.Empty;
            Direccion = string.Empty;
            FechaNacimiento = DateTime.Now;
            Balance = 0;
        }
    }
}
