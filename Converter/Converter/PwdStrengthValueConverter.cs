using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace Converter
{
    public class PwdStrengthValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var val = (string)value;
            if (string.IsNullOrEmpty(val))
            {
                return "Nothing";
            }
            else
            if (val.Length < 6)
            {
                return "Poor";
            }
            else if (val.Length >= 6 && val.Length <= 9)
            {
                return "moderate";
            }
            else
            {
                return "Good";
            }

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
