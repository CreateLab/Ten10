using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Ten10.Views
{
    public class SupportWindow : Window
    {
        public SupportWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}