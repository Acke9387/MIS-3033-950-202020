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

namespace WPF_FirstApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            lblMessage.Content = string.Empty;
            btnPizza.Background = Brushes.Gray;
        }

        private void btnPizza_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello World!");
            MessageBox.Show("Hello World!", "POP-UP", MessageBoxButton.OKCancel, MessageBoxImage.Exclamation);
            lblMessage.Content = txtInput.Text;
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnPizza_MouseEnter(object sender, MouseEventArgs e)
        {
            wndMain.Background = Brushes.Brown;
        }

        private void btnPizza_MouseLeave(object sender, MouseEventArgs e)
        {
            wndMain.Background = Brushes.Gray;
        }

        private void btnPizza_IsMouseDirectlyOverChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            btnPizza.Background = Brushes.Brown;
        }

    }
}
