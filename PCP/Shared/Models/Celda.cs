using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupplyChain.Shared.Models
{
    [Table("Celdas")]
    public class Celda
    {
        [Key]
        [ColumnaGridViewAtributo(Name = "Codigo")]
        public string CG_CELDA { get; set; }
        [ColumnaGridViewAtributo(Name = "Celda")]
        public string DES_CELDA { get; set; }
        [ColumnaGridViewAtributo(Name = "Ärea")]
        public int? CG_AREA { get; set; }
        [ColumnaGridViewAtributo(Name = "Cat.Operario")]
        public int? CG_CATEOP { get; set; }
        [ColumnaGridViewAtributo(Name = "Cap.Ilimitada")]
        public int? ILIMITADA { get; set; }
        [ColumnaGridViewAtributo(Name = "Coef.Uso")]
        public decimal? COEFI { get; set; }
        [ColumnaGridViewAtributo(Name = "Celda del proveedor")]
        public int CG_PROVE { get; set; }
        [ColumnaGridViewAtributo(Name = "Valor de amortización")]
        public decimal? VALOR_AMOR { get; set; }
        [ColumnaGridViewAtributo(Name = "Valor de mercado")]
        public decimal? VALOR_MERC { get; set; }
        [ColumnaGridViewAtributo(Name = "Moneda")]
        public string MONEDA { get; set; }
        [ColumnaGridViewAtributo(Name = "Años amortización")]
        public decimal? CANT_ANOS { get; set; }
        [ColumnaGridViewAtributo(Name = "Cantidad unidad")]
        public decimal? CANT_UNID { get; set; }
        [ColumnaGridViewAtributo(Name = "Años de reposición")]
        public decimal? REP_ANOS { get; set; }
        [ColumnaGridViewAtributo(Name = "M2 que ocupa")]
        public decimal? M2 { get; set; }
        [ColumnaGridViewAtributo(Name = "Energía")]
        public decimal? ENERGIA { get; set; }
        [ColumnaGridViewAtributo(Name = "Combustible")]
        public decimal? COMBUST { get; set; }
        [ColumnaGridViewAtributo(Name = "Aire comprimido")]
        public decimal? AIRE_COMP { get; set; }
        [ColumnaGridViewAtributo(Name = "Tipo celda")]
        public int? CG_TIPOCELDA { get; set; }
        [ColumnaGridViewAtributo(Name = "Depósito celda")]
        public int? CG_DEPOSM{ get; set; }
        [ColumnaGridViewAtributo(Name = "Compañía")]
        public int? CG_CIA { get; set; }


    }
}
