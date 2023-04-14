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

namespace TereschenkoEA_VAR23
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void box1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (box1.Text.Length < 10 || box1.Text.Length > 40) 
            {
                box1.Background = Brushes.Red;
                string text = "Минимальное количество символов 10, максимальное 40";
                block1.Text = text;

            }
            else
            {
                box1.Background = Brushes.Green;
                string text1 = "Все хорошо";
                block1.Text = text1;
            }
        }

        private void box2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (box2.Text.Length < 10 || box2.Text.Length > 60)
            {
                box2.Background = Brushes.Red;
                string text = "Минимальное количество символов 10, максимальное 60";
                block2.Text = text;

            }
            else
            {
                box2.Background = Brushes.Green;
                string text1 = "Все хорошо";
                block2.Text = text1;
            }
        }

        private void box3_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (box3.Text.Length < 10 || box3.Text.Length > 60)
            {
                box3.Background = Brushes.Red;
                string text = "Минимальное количество символов 10, максимальное 60";
                block3.Text = text;

            }
            else
            {
                box3.Background = Brushes.Green;
                string text1 = "Все хорошо";
                block3.Text = text1;
            }
        }

        private void box4_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1) || (box4.Text == "" && e.Text == "-"))
            {
                e.Handled = true;
            }
        }
    }
}
