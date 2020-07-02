using SupplyChain.Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SupplyChain.Shared.HelpersAtributo
{
    /// <summary>
    /// Control de cantidades ingresadas para los diferentes tipos de operaciones
    /// </summary>
    public class ControlCantAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var stock = (Stock)validationContext.ObjectInstance;

            decimal? cant = (decimal?)value;
            return stock.TIPOO == 6 && stock.STOCK > stock.ResumenStock?.STOCK
                ? new ValidationResult($"La cantidad ingresada no puede ser mayor a la del stock ({stock.ResumenStock?.STOCK})")
                : ValidationResult.Success;

            //var cant = (decimal?)value;
            //return cant == default || cant == 0
            //    ? new ValidationResult("Ingresar cantidad")
            //    : ValidationResult.Success;
        }
    }
}
