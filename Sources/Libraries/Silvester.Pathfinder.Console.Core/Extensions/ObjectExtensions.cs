using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Console.Core.Extensions
{
    public static class ObjectExtensions
    {
        public static List<ValidationResult> ValidateDataAnnotations(this object instance, bool validateAllProperties = false)
        {
            ValidationContext context = new ValidationContext(instance);
            List<ValidationResult> results = new List<ValidationResult>();

            Validator.TryValidateObject(instance, context, results);
            return results;
        }
    }
}
