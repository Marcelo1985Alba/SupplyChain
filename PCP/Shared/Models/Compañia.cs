using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupplyChain.Shared.Models
{
    [Table("Cia")]
    public class Compañia
    {
        [Key]
        [ColumnaGridViewAtributo(Name = "Codigo")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? CG_CIA { get; set; }
        [ColumnaGridViewAtributo(Name = "Compañía")]
        public string DES_CIA { get; set; }
        [ColumnaGridViewAtributo(Name = "Domicilio fiscal")]
        public string DOM_FISC { get; set; }
        [ColumnaGridViewAtributo(Name = "Localidad")]
        public string LOC_FISC { get; set; }
        [ColumnaGridViewAtributo(Name = "Provincia")]
        public string DES_PROV { get; set; }
        [ColumnaGridViewAtributo(Name = "Codigo zip")]
        public string COD_POST { get; set; }
        [ColumnaGridViewAtributo(Name = "Pais")]
        public string DES_PAIS { get; set; }
        [ColumnaGridViewAtributo(Name = "Domicilio comercial")]
        public string DOM_COM { get; set; }
        [ColumnaGridViewAtributo(Name = "Localidad")]
        public string LOC_COM { get; set; }
        [ColumnaGridViewAtributo(Name = "Prefijo TE pais")]
        public int? PREFIJO { get; set; }
        [ColumnaGridViewAtributo(Name = "Teléfono")]
        public string TELEFONO { get; set; }
        [ColumnaGridViewAtributo(Name = "CUIT")]
        public string CUIT { get; set; }
        [ColumnaGridViewAtributo(Name = "IIBB")]
        public string IIBB { get; set; }
        [ColumnaGridViewAtributo(Name = "Actividad")]
        public string ACTIVIDAD { get; set; }
        [ColumnaGridViewAtributo(Name = "Fecha contratación")]
        public DateTime FE_CONTRAT { get; set; }
        [ColumnaGridViewAtributo(Name = "Fecha desvinculación")]
        public string FE_CIERRE { get; set; }
        [ColumnaGridViewAtributo(Name = "Aviso")]
        public string AVISO { get; set; }




    }
}
