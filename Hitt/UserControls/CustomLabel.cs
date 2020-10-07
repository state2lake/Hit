using System;
using Xamarin.Forms;

namespace Hitt.UserControls
{
    public class CustomLabel : Label
    {
        public static readonly BindableProperty SelectableProperty = BindableProperty.Create("Selectable", typeof(bool), typeof(CustomLabel), false, BindingMode.Default);
        public CustomLabel()
        {
        }

        public bool Selectable
        {
            get
            {
                return (bool)GetValue(SelectableProperty);
            }
            set
            {
                SetValue(SelectableProperty, value);
                OnPropertyChanged();
            }

        }
    }
}
