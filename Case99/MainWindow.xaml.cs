using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Case99
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keyboard.Modifiers == ModifierKeys.Control && e.Key == Key.Space)
            {
                var textBox = sender as TextBox;

                // ObjectDataProviderの中身を更新
                var provider = FindResource("itemsProvider") as ObjectDataProvider;
                provider.MethodParameters.Clear();
                //provider.MethodParameters.Add(GetCurrentWord(textBox));
                provider.MethodParameters.Add("aaaaa");
                provider.Refresh();

                // Popupを現在のキャレットのある位置へ表示
                popup.PlacementTarget = textBox;
                popup.PlacementRectangle =
                    textBox.GetRectFromCharacterIndex(textBox.CaretIndex);
                // 候補が0個の時は表示しない
                if (listBoxTarget.Items.Count != 0)
                {
                    popup.IsOpen = true;
                    listBoxTarget.Focus();
                }
                e.Handled = true;
            }
        }

        private void listBoxTarget_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.Key == Key.Escape)
            //{
            //    popup.IsOpen = false;
            //    return;
            //}

            //if (e.Key == Key.Enter)
            //{
            //    if (listBoxTarget.SelectedItem == null)
            //    {
            //        return;
            //    }
            //    var textBox = popup.PlacementTarget as TextBox;
            //    var caretIndex = textBox.CaretIndex;
            //    var currentWord = GetCurrentWord(textBox);
            //    var selectedText = listBoxTarget.SelectedItem as string;

            //    // 選択されたものを挿入
            //    var tmpText = textBox.Text.Remove(caretIndex - currentWord.Length, currentWord.Length);
            //    textBox.Text = tmpText.Insert(caretIndex - currentWord.Length, selectedText);
            //    textBox.CaretIndex = caretIndex + selectedText.Length;
            //    popup.IsOpen = false;
            //    textBox.Focus();
            //}
        }
    }
}
