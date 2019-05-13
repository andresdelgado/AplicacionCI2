using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerEntregaCi2.Models
{
    public class Tarea
    {
        [Key]
        [Column("idtarea")]
        public int idtarea { get; set; }
        [Column("fcreacion")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime fcreacion { get; set; }
        [StringLength(50)]
        [Column("descripcion")]
        public String descripcion { get; set; }
        [StringLength(2)]
        [Column("estado")]
        public String estado { get; set; }
        [Column("fvencimiento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime fvencimiento { get; set; }
        [Column("idautor")]
        public int idautor { get; set; }

        [ForeignKey("idautor")]
        public Autor autor { get; set; }
    }
}
