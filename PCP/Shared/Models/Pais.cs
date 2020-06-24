using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupplyChain.Shared.Models
{
    [Table("Pais")]
    public class pais
    {
        [Key]
        [ColumnaGridViewAtributo(Name = "Codigo")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Codigo { get; set; }
        [ColumnaGridViewAtributo(Name = "Pais")]
        public string Des_Pais { get; set; }
        [ColumnaGridViewAtributo(Name = "Es Mercosur")]
        public int? Mercosur { get; set; }
        [ColumnaGridViewAtributo(Name = "CUIT")]
        public string Cuit { get; set; }


    }
}
