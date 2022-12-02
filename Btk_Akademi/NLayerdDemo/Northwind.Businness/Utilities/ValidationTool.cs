using FluentValidation;
using Northwind.Businness.ValidationRules.FluentValidation;
using Northwind.Entites.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Businness.Utilities
{
    public static class ValidationTool 
    {
        public static void Validate(IValidator validator, object entity )
        {

            if (validator != null)
            {
                var context = new ValidationContext<object>(entity);
                var result = validator.Validate(context);
                if (result.Errors.Count > 0)
                     throw new ValidationException(result.Errors);
             }
        }
    }
}
