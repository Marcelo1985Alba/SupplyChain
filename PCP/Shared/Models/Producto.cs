using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupplyChain.Shared.Models
{
    [Table("Prod")]
    public class Producto
    {
        [Key]
        [ColumnaGridViewAtributo(Name = "Código producto")]
        public string CG_PROD { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Nombre producto")]
        public string DES_PROD { get; set; }
        [ColumnaGridViewAtributo(Name = "Tipo insumo")]
        public int? CG_ORDEN { get; set; }
        [ColumnaGridViewAtributo(Name = "Tipo producto")]
        public string TIPO { get; set; }
        [ColumnaGridViewAtributo(Name = "Unidad stock")]
        public string UNID { get; set; }
        [ColumnaGridViewAtributo(Name = "Factor de conversión")]
        public decimal? CG_DENSEG { get; set; }
        [ColumnaGridViewAtributo(Name = "Unidad comercial")]
        public string UNIDSEG { get; set; }
        [ColumnaGridViewAtributo(Name = "Peso")]
        public decimal PESO { get; set; }
        [ColumnaGridViewAtributo(Name = "Unidad peso")]
        public string UNIDPESO { get; set; }
        [ColumnaGridViewAtributo(Name = "Especificaciones")]
        public string ESPECIF { get; set; }
        [ColumnaGridViewAtributo(Name = "Norma")]
        public string NORMA { get; set; }
        [ColumnaGridViewAtributo(Name = "Exige despacho")]
        public int? EXIGEDESPACHO { get; set; }
        [ColumnaGridViewAtributo(Name = "Exige lote")]
        public int? EXIGELOTE { get; set; }
        [ColumnaGridViewAtributo(Name = "Exige serie")]
        public int? EXIGESERIE { get; set; }
        [ColumnaGridViewAtributo(Name = "Stock mínimo")]
        public int? EXIGEOA { get; set; }
        [ColumnaGridViewAtributo(Name = "Orden de armado")]
        public decimal? STOCKMIN { get; set; }
        [ColumnaGridViewAtributo(Name = "Lote óptimo compra")]
        public decimal? LOPTIMO { get; set; }
        [ColumnaGridViewAtributo(Name = "Area fabricación")]
        public int? CG_AREA { get; set; }
        [ColumnaGridViewAtributo(Name = "Línea fabricación")]
        public int? CG_LINEA { get; set; }
        [ColumnaGridViewAtributo(Name = "Activo")]
        public string ACTIVO { get; set; }
        [ColumnaGridViewAtributo(Name = "Tiempo fabricación")]
        public decimal? TIEMPOFAB { get; set; }
        [ColumnaGridViewAtributo(Name = "Costo fabricación")]
        public decimal? COSTO { get; set; }
        [ColumnaGridViewAtributo(Name = "Costo fabricación terceros")]
        public decimal? COSTOTER { get; set; }
        [ColumnaGridViewAtributo(Name = "Moneda costo")]
        public string MONEDA { get; set; }
        [ColumnaGridViewAtributo(Name = "Celda fabricación")]
        public string CG_CELDA { get; set; }
        [ColumnaGridViewAtributo(Name = "Tipo área fabricación")]
        public int? CG_TIPOAREA { get; set; }
        [ColumnaGridViewAtributo(Name = "Cuenta contable")]
        public decimal? CG_CUENT1 { get; set; }
        [ColumnaGridViewAtributo(Name = "Unidad equivalente costo")]
        public decimal? UNIDEQUI { get; set; }
        [ColumnaGridViewAtributo(Name = "Costo ultima compra")]
        public decimal? COSTOUC { get; set; }
        [ColumnaGridViewAtributo(Name = "Moneda ultima compra")]
        public string MONEDAUC { get; set; }
        [ColumnaGridViewAtributo(Name = "Costo ultima compra")]
        public decimal? COSTOUC1 { get; set; }
        [ColumnaGridViewAtributo(Name = "Fecha ultima compra")]
        public DateTime? FE_UC { get; set; }
        [ColumnaGridViewAtributo(Name = "Usuario")]
        public string USUARIO { get; set; }
        [ColumnaGridViewAtributo(Name = "Fecha registro")]
        public DateTime? FE_REG { get; set; }
        [ColumnaGridViewAtributo(Name = "Compañía")]
        public int? CG_CIA { get; set; }

    }
}
