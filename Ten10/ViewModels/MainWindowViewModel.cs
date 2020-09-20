using System;
using System.Collections.Generic;
using System.Text;
using Avalonia.Controls;
using ReactiveUI;

namespace Ten10.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private Window _window;
        private string _text;

        public MainWindowViewModel()
        {
            _window = new Views.SupportWindow();
            _window.DataContext = new SuprotVm();
            _window.Show();
        }
        public string Text
        {
            get => _text;
            set => this.RaiseAndSetIfChanged(ref _text, value);
        }

        public void Click()
        {
           ( _window.DataContext as IShowText)?.ShowText(_text);
        }
    }
}