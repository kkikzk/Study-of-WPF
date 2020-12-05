using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Case08.ViewModel
{
    public class NotificationObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// プロパティ値を変更するヘルパです。
        /// </summary>
        /// <typeparam name="T">プロパティの型を表します。</typeparam>
        /// <param name="target">変更するプロパティの実体を ref 指定します。</param>
        /// <param name="value">変更後の値を指定します。</param>
        /// <param name="propertyName">プロパティ名を指定します。</param>
        /// <returns>プロパティ値に変更があった場合に true を返します。</returns>
        protected bool SetProperty<T>(ref T target, T value, [CallerMemberName]string propertyName = null)
        {
            if (Equals(target, value))
            {
                return false;
            }

            target = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            return true;
        }
    }
}
