using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupplyChain.Shared.Models
{
    [Table("Areas")]
    public class Area
    {
        [Key]
        [ColumnaGridViewAtributo(Name = "Codigo")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? CG_AREA { get; set; }
        [ColumnaGridViewAtributo(Name = "Nombre del área")]
        public string DES_AREA { get; set; }
        [ColumnaGridViewAtributo(Name = "Tipo de área")]
        public int? CG_TIPOAREA { get; set; }
        [ColumnaGridViewAtributo(Name = "?Area del Proveedor")]
        public int? CG_PROVE { get; set; }
        [ColumnaGridViewAtributo(Name = "Compañía")]
        public int? CG_CIA { get; set; }


    }
}
