using System;
using System.Collections.Generic;
using System.Text;

namespace RegistroIncripcion.Entidades
{
    public class Inscripciones
    {
        public int IncripcionId { get; set; }
        public DateTime Fecha { get; set; }
        public int PersonaId { get; set; }
        public String Comentario { get; set; }
        public int Monto { get; set; }
        public int Balance { get; set; }

        public Inscripciones()
        {
            IncripcionId = 0;
            Fecha = DateTime.Now;
            PersonaId = 0;
            Comentario = string.Empty;
            Monto = 0;
            Balance = 0;
        }
    }
}
