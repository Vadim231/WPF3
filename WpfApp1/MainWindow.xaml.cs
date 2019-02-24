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

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Cut();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            textBox1.Copy();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            textBox1.Paste();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            grid2.Background = new SolidColorBrush(Colors.Aqua);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            grid2.Background = new SolidColorBrush(Colors.Red);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            grid2.Background = new SolidColorBrush(Colors.Yellow);
        }

        private void Button_MouseMove(object sender, MouseEventArgs e)
        {
            Random r = new Random();

            but1.Margin = new Thickness(r.Next(0, 100));
        }
    }
}
