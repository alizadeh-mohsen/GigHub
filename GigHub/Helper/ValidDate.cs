using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace GigHub.Helper
{
    public class ValidDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime d;
            var result = DateTime.TryParseExact(value.ToString(),"yyyy/MM/dd",CultureInfo.CurrentCulture, DateTimeStyles.None,out d);

            return result && d > DateTime.Now;
        }
    }
}
