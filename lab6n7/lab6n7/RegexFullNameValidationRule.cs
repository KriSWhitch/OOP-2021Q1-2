using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace lab6n7
{
    public class RegexFullNameValidationRule : ValidationRule
    {
        private const string Message = "Название должно быть от 3-х до 32-х символов!";
        private Regex regex = new Regex(pattern: @"^[a-zа-я0-9-_\s]{3,32}$");

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (regex.IsMatch((string)value))
                return ValidationResult.ValidResult;
            else
                return new ValidationResult(false, Message);
        }
    }
}
