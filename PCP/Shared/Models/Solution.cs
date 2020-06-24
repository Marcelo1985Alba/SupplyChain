using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupplyChain.Shared.Models
{
    [Table("Solution")]
    public class Solution
    {
        [Key]
        [ColumnaGridViewAtributo(Name = "Codigo")]
        public string CAMPO { get; set; }
        [ColumnaGridViewAtributo(Name = "Tipo")]
        public string TIPO { get; set; }
        [ColumnaGridViewAtributo(Name = "Valor numérico")]
        public decimal? VALORN { get; set; }
        [ColumnaGridViewAtributo(Name = "Valor alfanumérico")]
        public string VALORC { get; set; }
        [ColumnaGridViewAtributo(Name = "Nombre del campo")]
        public string DESCRIP { get; set; }
        [ColumnaGridViewAtributo(Name = "Compañía")]
        public int? CG_CIA { get; set; }


    }
}
