using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupplyChain.Shared.Models
{
    [Table("TipoMat")]
    public class TipoMateria
    {
        [Key]
        [ColumnaGridViewAtributo(Name = "Tipo materia")]
        public string TIPO { get; set; }
        [ColumnaGridViewAtributo(Name = "Compañía")]
        public int? CG_CIA { get; set; }


    }
}
