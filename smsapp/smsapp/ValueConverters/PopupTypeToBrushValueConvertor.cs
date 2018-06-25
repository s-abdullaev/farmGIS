
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Media;

namespace smsapp
{
    public class PopupTypeToBrushValueConvertor : BaseValueConverter<PopupTypeToBrushValueConvertor>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var type = value as PopupType?;
            switch (type)
            {
                case PopupType.Success:
                    return Brushes.Green;
                case PopupType.Wait:
                    return Brushes.Green;
                default:
                    return Brushes.Red;
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
