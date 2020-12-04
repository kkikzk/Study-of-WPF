using System.Windows.Input;

namespace Case06.ViewModel
{
    internal class MainWindowViewModel
    {
        public string WindowTitle { get; } = "割り算計算";
        public int Width { set; get; } = 300;

        private DelegateCommand _calcCommand;
        public ICommand CalcCommand
        {
            get
            {
                return _calcCommand ?? (_calcCommand = new DelegateCommand(
                    _ => { },
                    _ => true
                ));
            }
        }
    }
}
