using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SupplyChain.Shared.Models
{
    public class ResumenStock
    {
        [ColumnaGridViewAtributo (Name = "Codigo Articulo")]
        public string CG_ART { get; set; }
        [ColumnaGridViewAtributo(Name = "Despacho")]
        public string DESPACHO { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Lote")]
        public string LOTE { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Serie")]
        public string SERIE { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Ubicacion")]
        public string UBICACION { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Stock")]
        public decimal STOCK { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Deposito")]
        public int CG_DEP { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Orden Ingreso")]
        public int CG_ORDING { get; set; } = 0;

        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Registro { get; set; }
    }
}
