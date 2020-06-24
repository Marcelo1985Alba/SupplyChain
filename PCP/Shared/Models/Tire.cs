using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SupplyChain.Shared.Models
{
    public class Tire
    {
        public int Tipoo { get; set; }
        [Required(ErrorMessage ="Ingresar Tipo de Operacion")]
        public string Descrip { get; set; }
    }
}
