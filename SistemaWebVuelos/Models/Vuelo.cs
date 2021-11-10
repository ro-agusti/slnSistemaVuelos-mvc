using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaWebVuelos.Models
{   [Table("Vuelo")]
    public class Vuelo
    {
        public int Id { get; set; }

        [Column(TypeName = "date")]
        //[RegularExpression(@"^(?:3[01]|[12][0-9]|0?[1-9])([\-/.])(0?[1-9]|1[1-2])\1\d{4}$", ErrorMessage = "Ingrese un formato de fecha válido, Por ejemplo: 20-05-2015")]
        public DateTime dateTime { get; set; }

        [Column(TypeName = "Varchar")]
        [Required(ErrorMessage = "Is Required")]
        [MaxLength(50)]
        public string Destino { get; set; }

        [Column(TypeName = "Varchar")]
        [Required(ErrorMessage = "Is Required")]
        [MaxLength(50)]
        public string Origen { get; set; }

        [Range(100,1000)]
        public int Matricula { get; set; }
    }
}