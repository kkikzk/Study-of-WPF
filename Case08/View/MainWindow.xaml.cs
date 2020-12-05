using MahApps.Metro.Controls.Dialogs;
using System.Windows;

namespace Case08.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MahApps.Metro.Controls.MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void InputBoxButton_Click(object sender, RoutedEventArgs e)
        {
            var settings = new MetroDialogSettings() { DefaultText = "最初に表示しておく文字列" };
            var result = await this.ShowInputAsync("タイトル", "何か入力してください。", settings);
            if (result == null)
            {
                // キャンセル
                return;
            }
            else
            {
                await this.ShowMessageAsync("タイトル", $"「{result}」が入力されました。");
            }
        }
    }
}
