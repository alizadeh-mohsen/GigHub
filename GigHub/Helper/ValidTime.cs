using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace GigHub.Helper
{
    public class ValidTime : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value is null) 
                return false;
            
            var result = DateTime.TryParseExact(value.ToString(), "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None, out _);
            return result;
        }
    }
}