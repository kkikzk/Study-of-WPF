using System.ComponentModel;
using System.Diagnostics;

namespace Case04
{
    internal class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _text;
        public string Text
        {
            set
            {
                if (_text != value)
                {
                    _text = value;
                    Debug.WriteLine($"{nameof(Text)} property called. => {value}");
                    Expression = _text.ToUpper();
                }
            }
            get
            {
                return _text;
            }
        }

        private string _expression;
        public string Expression
        {
            set
            {
                if (_expression != value)
                {
                    _expression = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Expression)));
                }
            }
            get
            {
                return _expression;
            }
        }
    }
}
