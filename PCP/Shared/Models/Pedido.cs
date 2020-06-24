using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupplyChain.Shared.Models
{
    [Table("Pedidos")]
	public class PedidosBak
	{
		[ColumnaGridViewAtributo(Name ="Vale")]
		public decimal VALE { get; set; }
		[ColumnaGridViewAtributo(Name = "Fecha Vale")]
		public DateTime FE_MOV { get; set; }
		public decimal VOUCHER { get; set; }
		public string COMPROB { get; set; }
		public string FACTURA { get; set; }
		public string LEYENDA { get; set; }
		public string REMITO { get; set; }
		public int TIPOO { get; set; }
		public decimal PRESUP { get; set; }
		public decimal PEDIDO { get; set; }
		public decimal NUMOCI { get; set; }
		public decimal OBRA { get; set; }
		public decimal OCOMPRA { get; set; }
		public decimal CG_ORDF { get; set; }
		public string OBSERVACIONES { get; set; }
		public string OBSERITEM { get; set; }
		public string OBS1 { get; set; }
		public string OBS2 { get; set; }
		public string OBS3 { get; set; }
		public string OBS4 { get; set; }
		public string AVISO { get; set; }
		public string DIRENT { get; set; }
		public int CG_ORDEN { get; set; }
		[ColumnaGridViewAtributo(Name ="Codigo Articulo")]
		public string CG_ART { get; set; }
		[ColumnaGridViewAtributo(Name = "Descripcion Articulo")]
		public string DES_ART { get; set; }
		public string TIPO { get; set; }
		public string LOTE { get; set; }
		public string SERIE { get; set; }
		public string UBICACION { get; set; }
		public string DESPACHO { get; set; }
		public decimal CG_ORDING { get; set; }
		public int CG_DEP { get; set; }
		public decimal CANTENT { get; set; }
		public decimal STOCK { get; set; }
		public string UNID { get; set; }
		public decimal CG_DEN { get; set; }
		public decimal STOCKA { get; set; }
		public string UNIDA { get; set; }
		public decimal CANTENTA { get; set; }
		public DateTime ENTRREAL { get; set; }
		public string MONEDA { get; set; }
		public decimal IMPORTE1 { get; set; }
		[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
		public decimal IMPORTE2 { get; set; }
		[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
		public decimal IMPORTE3 { get; set; }
		[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
		public decimal IMPORTE4 { get; set; }
		public decimal IMPORTE6 { get; set; }
		public decimal DESCUENTO { get; set; }
		public decimal BONIFIC { get; set; }
		public decimal IVA { get; set; }
		public decimal VA_INDIC { get; set; }
		public decimal CG_CUENT { get; set; }
		public string CUIT { get; set; }
		public int CG_PROVE { get; set; }
		public int DES_PROVE { get; set; }
		public int CG_CLI { get; set; }
		public string DES_CLI { get; set; }
		public string DIRECC { get; set; }
		public string LOCALIDAD { get; set; }
		public string CG_POSTA { get; set; }
		public string ORCO { get; set; }
		public decimal CANTPED { get; set; }
		public int FLAG { get; set; }
		public string USUARIO { get; set; }
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public decimal REGISTRO { get; set; }
		public int CG_CIA { get; set; }
	}
}
