using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace GigHub.ViewModels
{
    public class ValidTime : ValidationAttribute
    {
        /* Método que verificará se a hora inclusa pelo usuário é nulo ou
         * válido */
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value), 
                "HH:mm", 
                CultureInfo.CurrentCulture, 
                DateTimeStyles.None,
                out dateTime);
            
            return (isValid);
        }
    }
}