using Case08.Model;
using System;
using System.Windows.Input;

namespace Case08.ViewModel
{
    public class MainWindowViewModel : NotificationObject
    {
        public string WindowTitle { get; } = "割り算計算";
        public int Width { set; get; } = 300;

        public UserNotificationObject UserNotificationObject { get; } = new UserNotificationObject();

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
                        try
                        {
                            Result = new Divider(Lhs, Rhs).Execute();
                        }
                        catch (Exception e)
                        {
                            UserNotificationObject.NotifyError(e.Message);
                        }
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
