using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace EjercicioHerencia
{
    public class Catedratico:Padre
    {
        [Required(ErrorMessage = "El Titulo es Requerido")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "El Colegiado")]
        [StringLength(6, ErrorMessage = "Deben ser menos de 6 digitos")]
        public string Colegiado { get; set; }
        public Catedratico()
        {
            Titulo= string.Empty;
            Colegiado = string.Empty;
        }
    }
}
