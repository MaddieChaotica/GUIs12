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

namespace WPF_lab12
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

        private void News_Click(object sender, RoutedEventArgs e)
        {
            News news = new News();
            news.Show();
        }

        private void Imageboard_Click(object sender, RoutedEventArgs e)
        {
            ImageBoard imageBoard = new ImageBoard();
            imageBoard.Show();
        }

        private void Forum_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("WIP. Not yet implemented");
        }
    }
}
