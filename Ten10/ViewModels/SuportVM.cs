using ReactiveUI;

namespace Ten10.ViewModels
{
    public class SuprotVm:ViewModelBase,IShowText
    {
        private string _text;

        public string Text
        {
            get => _text;
            set => this.RaiseAndSetIfChanged(ref _text, value);
        }

        public void ShowText(string s)
        {
            Text = s;
        }
    }
}