using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace GigHub.Helper
{
    public class ValidDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value is null)
                return false;
            
            var result = DateTime.TryParseExact(Convert.ToString(value),"yyyy/MM/dd",CultureInfo.CurrentCulture, DateTimeStyles.None,out var d);
            return result && d > DateTime.Now;
        }
    }
}
