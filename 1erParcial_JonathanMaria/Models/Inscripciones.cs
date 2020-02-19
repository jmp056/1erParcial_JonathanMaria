using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _1erParcial_JonathanMaria.Models
{
    public class Inscripciones
    {
        [Key]
        public int InscripcionId { get; set; }
        [Required(ErrorMessage ="El semestre no puede estar vacio!..")]
        public string Semestre { get; set; }
        [Required]
        [Range(minimum:1, maximum:100, ErrorMessage ="El limine de creditos debe estar comprendido entre 1 y 100!...")]
        public int Limite { get; set; }
        [Required]
        [Range(minimum: 0, maximum: 100, ErrorMessage = "Los creditos tomados deben estar comprendidos entre 1 y la cantidad de creditos disponibles!...")]
        public int Tomados { get; set; }
        [Required]
        [Range(minimum: 0, maximum: 100, ErrorMessage = "Los creditos tomados no pueden ser mayores a 100 o a la cantidad de creditos limite!...")]
        public int Disponibles { get; set; }
    }
}
