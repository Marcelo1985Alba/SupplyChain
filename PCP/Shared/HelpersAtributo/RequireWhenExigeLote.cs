using SupplyChain.Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SupplyChain.Shared.HelpersAtributo
{
    public class RequireWhenExigeLoteAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var stock = (Stock)validationContext.ObjectInstance;
            if (stock.EXIGELOTE == 0)
                return ValidationResult.Success;

            var lote = value as string;
            return string.IsNullOrWhiteSpace(lote)
                ? new ValidationResult("Ingresar Lote: el insumo exige lote")
                : ValidationResult.Success;
        }
    }

}
