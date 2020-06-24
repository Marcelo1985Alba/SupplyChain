using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupplyChain.Shared.Models
{
    [Table("Compras")]
    public class Compra
    {
        [ColumnaGridViewAtributo(Name = "Número")]
        public decimal? NUMERO { get; set; }
        [ColumnaGridViewAtributo(Name = "Fecha emisión")]
        public DateTime FE_EMIT { get; set; }
        [ColumnaGridViewAtributo(Name = "Código")]
        public string CG_MAT { get; set; }
        [ColumnaGridViewAtributo(Name = "Nombre producto")]
        public string DES_MAT { get; set; }
        [ColumnaGridViewAtributo(Name = "Necesario")]
        public decimal? NECESARIO { get; set; }
        [ColumnaGridViewAtributo(Name = "Solicitado")]
        public decimal? SOLICITADO { get; set; }
        [ColumnaGridViewAtributo(Name = "Autorizado")]
        public decimal? AUTORIZADO { get; set; }
        [ColumnaGridViewAtributo(Name = "Unidad stock")]
        public string UNID { get; set; }
        [ColumnaGridViewAtributo(Name = "Unidad compra")]
        public string UNID1 { get; set; }
        [ColumnaGridViewAtributo(Name = "Factor conversión")]
        public decimal? CG_DEN { get; set; }
        [ColumnaGridViewAtributo(Name = "Precio unidad compra")]
        public decimal? PRECIO { get; set; }
        [ColumnaGridViewAtributo(Name = "Descuento")]
        public decimal? BON { get; set; }
        [ColumnaGridViewAtributo(Name = "Precio con descuento")]
        public decimal? PRECIONETO { get; set; }
        [ColumnaGridViewAtributo(Name = "Precio total")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? PRECIOTOT { get; set; }
        [ColumnaGridViewAtributo(Name = "Moneda")]
        public string MONEDA { get; set; }
        //[ColumnaGridViewAtributo(Name = "Proveedor")]
        //public int NROCLTE { get; set; }
        [ColumnaGridViewAtributo(Name = "Nombre proveedor")]
        public string DES_PROVE { get; set; }
        [ColumnaGridViewAtributo(Name = "Fecha prevista entrega")]
        public DateTime? FE_PREV { get; set; }
        [ColumnaGridViewAtributo(Name = "Fecha real entrega")]
        public DateTime? FE_REAL { get; set; }
        [ColumnaGridViewAtributo(Name = "Fecha vencimiento")]
        public DateTime? FE_VENC { get; set; }
        [ColumnaGridViewAtributo(Name = "Fecha cierre")]
        public DateTime? FE_CIERRE { get; set; }
        //[ColumnaGridViewAtributo(Name = "Fecha precio")]
        //public DateTime FE_PREC { get; set; }
        [ColumnaGridViewAtributo(Name = "Condiciones compra")]
        public string CONDVEN { get; set; }
        //[ColumnaGridViewAtributo(Name = "Condiciones precio")]
        //public string CONDPREC { get; set; }
        //[ColumnaGridViewAtributo(Name = "Condiciones importación")]
        //public string CONDVENEX { get; set; }
        [ColumnaGridViewAtributo(Name = "Especific.particulares")]
        public string ESPECIFICA { get; set; }
        //[ColumnaGridViewAtributo(Name = "Especific.grales")]
        //public string ESTEGEN { get; set; }
        [ColumnaGridViewAtributo(Name = "Preparación")]
        public bool ABIERTOPREPARACION { get; set; }
        [ColumnaGridViewAtributo(Name = "Fecha requisición")]
        public DateTime? FE_REQ { get; set; }
        [ColumnaGridViewAtributo(Name = "Fecha autorización")]
        public DateTime? FE_AUTREQ { get; set; }
        [ColumnaGridViewAtributo(Name = "Proveedor")]
        public int? CG_PROVE { get; set; }
        [ColumnaGridViewAtributo(Name = "Proveedor")]
        public int? CG_PROVEREQ { get; set; }
        [ColumnaGridViewAtributo(Name = "Observaciones")]
        public string OBSEREQ { get; set; }
        [ColumnaGridViewAtributo(Name = "Tilde")]
        public string MARCAREQ { get; set; }
        [ColumnaGridViewAtributo(Name = "Avance")]
        public decimal? AVANCE { get; set; }
        [ColumnaGridViewAtributo(Name = "Texto observado")]
        public string TXTOBSERVADO { get; set; }
        [ColumnaGridViewAtributo(Name = "Texto corregido")]
        public string TXTCORREGIDO { get; set; }
        [ColumnaGridViewAtributo(Name = "Autorizador")]
        public string USUARIO_AUT { get; set; }
        [ColumnaGridViewAtributo(Name = "Fecha autorización")]
        public DateTime? FE_AUT { get; set; }
        //[ColumnaGridViewAtributo(Name = "Fecha cierre")]
        //public DateTime FE_CIERREQ { get; set; }
        [ColumnaGridViewAtributo(Name = "Usuario requisidor")]
        public string USUREQ { get; set; }
        [ColumnaGridViewAtributo(Name = "Observaciones")]
        public string OBSERVACIONES { get; set; }
        [ColumnaGridViewAtributo(Name = "Usuario")]
        public string USUARIO { get; set; }
        [ColumnaGridViewAtributo(Name = "Fecha registro")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime FE_REG { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ColumnaGridViewAtributo(Name = "Registro")]
        public decimal? REGISTRO { get; set; }
        [ColumnaGridViewAtributo(Name = "Compañía")]
        public int? CG_CIA { get; set; }
    }
}
