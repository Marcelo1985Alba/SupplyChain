using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupplyChain.Shared.Models
{
    [Table("Prov")]
    public class Provincia
    {
        [Key]
        [ColumnaGridViewAtributo(Name = "Codigo")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? CG_PROV { get; set; }
        [ColumnaGridViewAtributo(Name = "Provincia")]
        public string DES_PROV { get; set; }
        [ColumnaGridViewAtributo(Name = "Pais")]
        public int? CG_PAIS { get; set; }

    }
}
