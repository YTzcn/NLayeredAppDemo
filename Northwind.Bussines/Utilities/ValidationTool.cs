using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Northwind.Bussines.ValidationRules.FluentValidation;
using Northwind.Entities.Abstract;
using Northwind.Entities.Concrete;

namespace Northwind.Bussines.Utilities
{
    static public class ValidationTool
    {
        public static void Validate(IValidator validator, object entity)
        {
            var context = new ValidationContext<object>(entity);
            var result = validator.Validate(context);
            if (result.Errors.Count > 0)
            {
                string AllMessages = result.ToString("\n");
                throw new Exception(AllMessages);
            }
        }
    }
}
