using SupplyChain.Shared.HelpersAtributo;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupplyChain.Shared.Models
{
    [Table("Pedidos")]
    public class Stock
    {
        /*AGREGO CAMPOS (EXIGEDESPACHO, EXIGELOTE, EXIGESERIE) NO MAPEADOS A LA BASE DE DATOS 
         * QUE DEBEN SER SETEADOS POR EL PRODUCTO PARA VALIDACIONES.
         * PARA DETERMINAR SI LOS CAMPOS DESPACHO, SERIE Y LOTE
         * DEBEN SER REQUERIDOS. DE NO AGREGAR ESTO NO PERMITE REALIZAR LA GRABACION EN LA BASE DE DATOS POR EF
         * SE CREA UN ATRIBUTO ESPECIAL PARA CADA CAMPO: Ejemplo RequireWhenExigeDespacho
         */
        [NotMapped]
        public int? EXIGEDESPACHO { get; set; } = 0;
        [NotMapped]
        public int? EXIGELOTE { get; set; } = 0;
        [NotMapped]
        public int? EXIGESERIE { get; set; } = 0;


        [ColumnaGridViewAtributo(Name = "Vale")]
        public decimal? VALE { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Fecha vale")]
        public DateTime FE_MOV { get; set; }
        [ColumnaGridViewAtributo(Name = "Asiento contable")]
        public decimal? VOUCHER { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Comprobante")]
        public string COMPROB { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Factura")]
        public string FACTURA { get; set; } = "0000-00000000";
        [ColumnaGridViewAtributo(Name = "Letra de la factura")]
        public string LEYENDA { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Remito")]
        public string REMITO { get; set; } = "0000-00000000";
        [ColumnaGridViewAtributo(Name = "Tipo de operación")]
        public int? TIPOO { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Pedido")]
        public decimal? PEDIDO { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Orden de compra cliente")]
        public decimal? NUMOCI { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Orden de compra proveedor")]
        public decimal? OCOMPRA { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Orden de fabricación")]
        public decimal? CG_ORDF { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Observaciones")]
        public string OBSERVACIONES { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Especificaciones")]
        public string OBSERITEM { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Observaciones")]
        public string OBS1 { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Observaciones")]
        public string OBS2 { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Observaciones")]
        public string OBS3 { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Observaciones")]
        public string OBS4 { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Aviso")]
        public string AVISO { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Dirección entrega")]
        public string DIRENT { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Tipo insumo")]
        public int? CG_ORDEN { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Código artículo")]
        public string CG_ART { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Nombre artículo")]
        public string DES_ART { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Tipo artículo")]
        public string TIPO { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Lote")]
        [RequireWhenExigeLote]
        public string LOTE { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Serie")]
        [RequireWhenExigeSerie]
        public string SERIE { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Despacho")]
        [RequireWhenExigeDespacho]
        public string DESPACHO { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Ubicación")]
        public string UBICACION { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Depósito")]
        public int? CG_DEP { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Cantidad")]
        public decimal? CANTENT { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Cantidad operación")]
        public decimal? STOCK { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Unidad stock")]
        public string UNID { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Factor conversión")]
        public decimal? CG_DEN { get; set; } = 1;
        [ColumnaGridViewAtributo(Name = "Cantidad comercial")]
        public decimal? STOCKA { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Unidad comercial")]
        public string UNIDA { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Cantidad comercial")]
        public decimal? CANTENTA { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Fecha entrega")]
        public DateTime ENTRREAL { get; set; }
        [ColumnaGridViewAtributo(Name = "Moneda")]
        public string MONEDA { get; set; } = "PESOS";
        [ColumnaGridViewAtributo(Name = "Precio unitario")]
        public decimal? IMPORTE1 { get; set; } = 0;
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [ColumnaGridViewAtributo(Name = "Precio total")]
        public decimal? IMPORTE2 { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [ColumnaGridViewAtributo(Name = "Importe del descuento")]
        public decimal? IMPORTE3 { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [ColumnaGridViewAtributo(Name = "Precio total con descuento")]
        public decimal? IMPORTE4 { get; set; }
        [ColumnaGridViewAtributo(Name = "Precio")]
        public decimal? IMPORTE6 { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Porciento descuento")]
        public decimal? DESCUENTO { get; set; } = 1;
        [ColumnaGridViewAtributo(Name = "Porciento bonificación")]
        public decimal? BONIFIC { get; set; } = 1;
        [ColumnaGridViewAtributo(Name = "Porciento IVA")]
        public decimal? IVA { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Indice conversión moneda")]
        public decimal? VA_INDIC { get; set; } = 1;
        [ColumnaGridViewAtributo(Name = "Cuenta contable")]
        public decimal? CG_CUENT { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "CUIT")]
        public string CUIT { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Código proveedor")]
        public int? CG_PROVE { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Nombre proveedor")]
        public string DES_PROVE { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Código cliente")]
        public int? CG_CLI { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Nombre cliente")]
        public string DES_CLI { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Dirección")]
        public string DIRECC { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Localidad")]
        public string LOCALIDAD { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Código postal")]
        public string CG_POSTA { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Orden compra cliente")]
        public string ORCO { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Cantidad pedida")]
        public decimal? CANTPED { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Flag")]
        public int? FLAG { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Usuario")]
        public string USUARIO { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Fecha registro")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime FE_REG { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ColumnaGridViewAtributo(Name = "Registro")]
        public decimal? REGISTRO { get; set; }
        [ColumnaGridViewAtributo(Name = "Compañía")]
        public int? CG_CIA { get; set; } = 0;
    }
}
