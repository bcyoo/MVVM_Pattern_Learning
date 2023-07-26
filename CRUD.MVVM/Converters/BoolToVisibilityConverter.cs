using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;


/*
New 버튼을 클릭해서 IsEditing 값을 변경해서 논리적으로 수정하는 상태를 알수 있음
이제 이 상태 값을 이용해서 view 상태를 변경할 것


IValueConverter를 인터페이스를 사용하는 컨터버를 하나 추가,
이 컨버터는 true이면 TrueValue 반환, False면 FalseValue 반환

입력된 값이 bool이 아니라면 아무것도 하지않음
binding.DoNothing
 */
namespace CRUD.MVVM.Converters
{
    public class BoolToVisibilityConverter : IValueConverter
    {
        public Visibility TrueValue { get; set; } = Visibility.Visible;
        public Visibility FalseValue { get; set; } = Visibility.Collapsed;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool boolValue)
            {
                if (boolValue)
                {
                    return TrueValue;
                }    
                else
                {
                    return FalseValue;
                }
            }
            return Binding.DoNothing;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
