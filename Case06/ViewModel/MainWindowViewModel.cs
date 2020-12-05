using Case06.Model;
using System.Windows.Input;

namespace Case06.ViewModel
{
    internal class MainWindowViewModel : NotificationObject
    {
        public string WindowTitle { get; } = "割り算計算";
        public int Width { set; get; } = 300;

        private decimal _lhs;
        public decimal Lhs
        {
            set { SetProperty(ref _lhs, value); }
            get { return _lhs; }
        }

        private decimal _rhs;
        public decimal Rhs
        {
            set { SetProperty(ref _rhs, value); }
            get { return _rhs; }
        }

        private DelegateCommand _calcCommand;
        public ICommand CalcCommand
        {
            get
            {
                return _calcCommand ??= new DelegateCommand(
                    _ =>
                    {
                        Result = new Divider(Lhs, Rhs).Execute();
                    },
                    _ => true
                );
            }
        }

        private decimal _result;
        public decimal Result
        {
            set { SetProperty(ref _result, value); }
            get { return _result; }
        }
    }
}
