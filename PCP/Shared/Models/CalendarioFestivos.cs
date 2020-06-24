using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupplyChain.Shared.Models
{
    public partial class CalendarioFestivos
    {
        [Key]
        [Column(TypeName = "decimal(18,0)")]
        public decimal Registro { get; set; }
        public Guid Guid { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
    }
}
