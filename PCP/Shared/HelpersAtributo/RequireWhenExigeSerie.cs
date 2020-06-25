using SupplyChain.Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SupplyChain.Shared.HelpersAtributo
{
    public class RequireWhenExigeSerieAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var stock = (Stock)validationContext.ObjectInstance;
            if (stock.EXIGESERIE == 0)
                return ValidationResult.Success;

            var serie = value as string;
            return string.IsNullOrWhiteSpace(serie)
                ? new ValidationResult("Ingresar Serie: el insumo exige despacho")
                : ValidationResult.Success;
        }
    }
}
