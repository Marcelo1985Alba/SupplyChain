using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SupplyChain.Shared.Models
{
    [Table("CateOperario")]
    public class CategoriaOperario
    {
        [Key]
        [ColumnaGridViewAtributo(Name = "Codigo")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? CG_CATEOP { get; set; }
        [ColumnaGridViewAtributo(Name = "Categoria")]
        public string DES_CATEOP { get; set; }
        [ColumnaGridViewAtributo(Name = "Valor hora")]
        public decimal? VALOR_HORA { get; set; }
        [ColumnaGridViewAtributo(Name = "Moneda")]
        public string MONEDA { get; set; }
        [ColumnaGridViewAtributo(Name = "Compañía")]
        public int? CG_CIA { get; set; }


    }
}
