using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerEntregaCi2.Models
{
    public class Autor
    {
        [Key]
        [Column("idautor")]
        public int idautor { get; set; }
        [StringLength(50)]
        [Column("nombre")]
        public String nombre { get; set; }
        [StringLength(50)]
        [Column("usuario")]
        public String usuario { get; set; }
        [StringLength(50)]
        [Column("contrasena")]
        public String contrasena { get; set; }
    }
}
