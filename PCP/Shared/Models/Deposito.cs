using SupplyChain.Shared.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupplyChain.Shared.Models
{
    [Table("Depos")]
    public class Deposito
    {
        [Key]
        [ColumnaGridViewAtributo(Name = "Codigo")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? CG_DEP { get; set; }
        [ColumnaGridViewAtributo(Name = "Depósito")]
        [Required(ErrorMessage ="Ingresar Deposito")]
        public string DES_DEP { get; set; }
        [ColumnaGridViewAtributo(Name = "Tipo")]
        public string TIPO_DEP { get; set; }
        [ColumnaGridViewAtributo(Name = "de Cliente")]
        public int? CG_CLI { get; set; }
        [ColumnaGridViewAtributo(Name = "de Proveedor")]
        public int? CG_PROVE { get; set; }
        [ColumnaGridViewAtributo(Name = "Compañía")]
        public int? CG_CIA { get; set; }


    }
}
