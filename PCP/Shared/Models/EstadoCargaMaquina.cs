using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupplyChain.Shared.Models
{
    [Table("EstadosCargaMaquinas")]
    public class EstadoCargaMaquina
    {
        [Key]
        [ColumnaGridViewAtributo(Name = "Codigo")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? CG_ESTADO { get; set; }
        [ColumnaGridViewAtributo(Name = "Estado carga máquina")]
        public string ESTADO { get; set; }
        [ColumnaGridViewAtributo(Name = "Rojo")]
        public int? R { get; set; }
        [ColumnaGridViewAtributo(Name = "Verde")]
        public int? G { get; set; }
        [ColumnaGridViewAtributo(Name = "Azul")]
        public int? B { get; set; }
        [ColumnaGridViewAtributo(Name = "Compañía")]
        public int? CG_CIA { get; set; }


    }
}
