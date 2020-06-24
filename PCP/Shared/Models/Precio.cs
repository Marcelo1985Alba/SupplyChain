using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupplyChain.Shared.Models
{
    [Table("Precios")]
    public class Precio
    {
        [Key]
        [ColumnaGridViewAtributo(Name = "Código artículo")]
        public string CG_ART { get; set; }
        [ColumnaGridViewAtributo(Name = "Nombre artículo")]
        public string DES_ART { get; set; }
        [ColumnaGridViewAtributo(Name = "Tipo insumo")]
        public int? CG_ORDEN { get; set; }
        [ColumnaGridViewAtributo(Name = "Unidad stock")]
        public string UNID { get; set; }
        [ColumnaGridViewAtributo(Name = "Lista A pesos")]
        public decimal? IMPORTE1 { get; set; }
        [ColumnaGridViewAtributo(Name = "Lista A dólares")]
        public decimal? IMPORTE2 { get; set; }
        [ColumnaGridViewAtributo(Name = "Lista B pesos")]
        public decimal? IMPB1 { get; set; }
        [ColumnaGridViewAtributo(Name = "Lista B dólares ")]
        public decimal? IMPB2 { get; set; }
        [ColumnaGridViewAtributo(Name = "Lista C pesos")]
        public decimal? IMPC1 { get; set; }
        [ColumnaGridViewAtributo(Name = "Lista C dólares")]
        public decimal? IMPC2 { get; set; }
        [ColumnaGridViewAtributo(Name = "Lista X pesos")]
        public decimal? IMPORTE61 { get; set; }
        [ColumnaGridViewAtributo(Name = "Lista X dólares")]
        public decimal? IMPORTE62 { get; set; }
        [ColumnaGridViewAtributo(Name = "Descuento")]
        public decimal? DESCUENTO { get; set; }
        [ColumnaGridViewAtributo(Name = "Exento de IVA")]
        public string EXEN { get; set; }
        [ColumnaGridViewAtributo(Name = "Marca")]
        public string MARCA { get; set; }
        [ColumnaGridViewAtributo(Name = "Punto de reposición")]
        public decimal? REPOS { get; set; }
        [ColumnaGridViewAtributo(Name = "Costo en pesos")]
        public decimal? COSTO1 { get; set; }
        [ColumnaGridViewAtributo(Name = "Costo en dólares")]
        public decimal? COSTO2 { get; set; }
        [ColumnaGridViewAtributo(Name = "Cuenta contable")]
        public decimal? CG_CUENT { get; set; }
        [ColumnaGridViewAtributo(Name = "Porciento de IVA")]
        public decimal? IVA { get; set; }
        [ColumnaGridViewAtributo(Name = "Activo")]
        public string ACTIVO { get; set; }
        [ColumnaGridViewAtributo(Name = "Especificaciones")]
        public string OBSERITEM { get; set; }
        [ColumnaGridViewAtributo(Name = "Fecha alta")]
        public DateTime FE_ALTA { get; set; }
        [ColumnaGridViewAtributo(Name = "Usuario")]
        public string USUARIO { get; set; }
        [ColumnaGridViewAtributo(Name = "Fecha registro")]
        public DateTime FE_REG { get; set; }
        [ColumnaGridViewAtributo(Name = "Compañía")]
        public int? CG_CIA { get; set; }


    }
}
