using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SupplyChain.Shared.Models
{
    [Table("Usuarios")]
    public class UsuarioOperador
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? id { get; set; }
        public Guid guid { get; set; }
        [ColumnaGridViewAtributo(Name = "Usuario")]
        public string Usuario { get; set; }
        [ColumnaGridViewAtributo(Name = "Clave")]
        public string Clave { get; set; }
        [ColumnaGridViewAtributo(Name = "Nombre")]
        public string Nombre { get; set; }
        [ColumnaGridViewAtributo(Name = "Apellido")]
        public string Apellido { get; set; }
        [ColumnaGridViewAtributo(Name = "Compañia")]
        public int? Cg_Cia { get; set; }


    }
}

