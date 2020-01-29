using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace GigHub.Helper
{
    public class ValidTime : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime d;
            var result = DateTime.TryParseExact(value.ToString(), "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None, out d);

            return result;
        }
    }
}