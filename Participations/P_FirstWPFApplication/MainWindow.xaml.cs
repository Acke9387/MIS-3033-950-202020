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

namespace P_FirstWPFApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            wndMain.Background = Brushes.Yellow;
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            string dobEntry = txtDOB.Text;
            DateTime dob = Convert.ToDateTime(dobEntry);
            dob = dpDOB.SelectedDate.Value;


            TimeSpan age = DateTime.Now - dob;
            MessageBox.Show($"{name} you are {(age.TotalDays / 365).ToString("N0")} years old!");

        }

        private void btnSubmit_MouseEnter(object sender, MouseEventArgs e)
        {
            wndMain.Background = Brushes.Red;
        }

        private void btnSubmit_MouseLeave(object sender, MouseEventArgs e)
        {
            wndMain.Background = Brushes.Yellow;
        }
    }
}
