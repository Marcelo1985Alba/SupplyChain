using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupplyChain.Shared.Models
{
    [Table("Programa")]
	public class Programa
	{
		[ColumnaGridViewAtributo(Name = "Codigo Producto")]
		public string CG_PROD { get; set; }
		public string DES_PROD { get; set; }
		public int CG_FORM { get; set; }
		[Column(TypeName = "decimal(18,4)")]
		[ColumnaGridViewAtributo(Name = "Cantidad")]
		public decimal CANT { get; set; }
		public DateTime FE_ENTREGA { get; set; }
		[ColumnaGridViewAtributo(Name ="Fecha Emision")]
		public DateTime FE_EMIT { get; set; }
		public int CG_REG { get; set; }
		public DateTime? FE_CIERRE { get; set; }
		public string CG_R { get; set; }
		public int CG_ORDEN { get; set; }
		public string LINEA { get; set; }

		[Column(TypeName = "decimal(18,0)")]
		public decimal PEDIDO { get; set; }
		public int CG_CLI { get; set; }
		public int CG_FLAG { get; set; }
		[Column(TypeName = "decimal(18,0)")]
		[ColumnaGridViewAtributo(Name = "Ord. Fab")]
		public decimal CG_ORDF { get; set; }
		[ColumnaGridViewAtributo(Name = "Fecha Fab")]
		public string HS_ORDF { get; set; }
		[Column(TypeName = "decimal(18,4)")]
		public decimal CANTORD { get; set; }
		public string USUARIO { get; set; }
		public int CG_CLAS { get; set; }
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Column(TypeName = "decimal(18,0)")]
		public decimal REGISTRO { get; set; }
		public string CAMPOCOM1 { get; set; }
		public string CAMPOCOM2 { get; set; }
		public DateTime FE_REG { get; set; }
		[Column(TypeName = "decimal(18,0)")]
		public decimal CG_ORDFORIG { get; set; }
		[Column(TypeName = "decimal(18,0)")]
		public decimal CG_ORDFASOC { get; set; }
		[Column(TypeName = "decimal(18,0)")]
		public decimal CG_CONFASOC { get; set; }
		public int CG_AREA { get; set; }
		public int Cg_Cia { get; set; }
		public int SEMANA { get; set; }
		public DateTime? FE_PLANTA { get; set; }
		public string OBSERV { get; set; }
		public int CG_ESTADOCARGA { get; set; }
		public DateTime? HS_INICIOPREPARACION { get; set; }
		public DateTime? HS_FINPREPARACION { get; set; }
		[Column(TypeName = "decimal(18,4)")]
		public decimal TIEMPOSECUEN { get; set; }
		public string OBSERSECUEN { get; set; }
		public DateTime? FE_ANUL { get; set; }
		public DateTime? FE_CURSO { get; set; }
		public DateTime? FE_FIRME { get; set; }
		public DateTime? FE_PLAN { get; set; }
		public string CG_CELDA { get; set; }
		public int CG_ESTADO { get; set; }
		[Column(TypeName = "decimal(18,4)")]
		public decimal SEGFAB { get; set; }
		[Column(TypeName = "decimal(18,4)")]
		public decimal CANTFAB { get; set; }
		public int ORDEN { get; set; }
		[Column(TypeName = "decimal(18,4)")]
		public decimal MINFAB { get; set; }
		[Column(TypeName = "decimal(18,4)")]
		public decimal HORASFAB { get; set; }
		[Column(TypeName = "decimal(18,4)")]
		public decimal DIASFAB { get; set; }
		[Column(TypeName = "decimal(18,4)")]
		public decimal DISFAB { get; set; }
		public int SEM_ORIGEN { get; set; }
		public int SEM_ABAST { get; set; }
		public int SEM_ABAST_PURO { get; set; }
		public string PROCESO { get; set; }
		public bool INSUMOS_ENTREGADOS_A_PLANTA { get; set; }
		public DateTime? FECHA_PREVISTA_FABRICACION { get; set; }
		public DateTime? FECHA_INICIO_REAL_FABRICACION { get; set; }
	}
}
