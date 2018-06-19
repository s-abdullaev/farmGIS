using System.Windows;
using System.Windows.Controls;

namespace smsapp
{
    public class PanelChildMarginproperty:BaseAttachedProperty<PanelChildMarginproperty,string>
    {
        public override void OnValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            //Get the panel (grid)
            var panel = (sender as Panel);

            //Wait for load 
            panel.Loaded += (s, o) =>
              {
                  // Loop each children
                  foreach (var child in panel.Children)
                      (child as FrameworkElement).Margin = (Thickness)(new ThicknessConverter().ConvertFromString(e.NewValue as string));
              };
        }
    }
}
