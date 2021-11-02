using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace MemeMaker
{
    class ActivarBorderConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Me guardo el valor del isChecked, dependiendo si esta marcado o no devuelvo un grosor 2 o un grosor 0 //
            bool estamarcado = (bool)value;
            if (estamarcado)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
