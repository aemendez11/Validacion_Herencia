using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    public class Administrativo:Padre
    {
        public string Profesion { get; set; }
        public int Iggs { get; set; }

        public Administrativo()
        {
            Profesion= string.Empty;
        }
    }
}
