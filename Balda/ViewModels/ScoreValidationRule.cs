using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Balda.ViewModels
{
    class ScoreValidationRule : System.Windows.Controls.ValidationRule
    {
        public Type ValidationType { get; set; }
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string strValue = Convert.ToString(value);

            if (string.IsNullOrEmpty(strValue))
                return new ValidationResult(false, strValue);
            int s = Int32.Parse(strValue);
            if(s > 21 || s < 1)
            {
                return new ValidationResult(true, null);
            }
            else
            {
                return new ValidationResult(false, "Введите значение от 1 до 21");
            }
        }
    }
}
