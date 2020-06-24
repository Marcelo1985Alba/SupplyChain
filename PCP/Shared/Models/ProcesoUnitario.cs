using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupplyChain.Shared.Models
{
    [Table("Protab")]
    public class ProcesoUnitario
    {
        [Key]
        [ColumnaGridViewAtributo(Name = "Codigo")]
        public string PROCESO { get; set; }
        [ColumnaGridViewAtributo(Name = "Proceso unitario")]
        public string DESCRIP { get; set; }
        [ColumnaGridViewAtributo(Name = "Observacioes")]
        public string OBSERVAC { get; set; }
        [ColumnaGridViewAtributo(Name = "Compañía")]
        public int? CG_CIA { get; set; }


    }
}
