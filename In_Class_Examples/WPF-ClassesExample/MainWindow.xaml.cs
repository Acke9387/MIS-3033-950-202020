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

namespace WPF_ClassesExample
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

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string name, breed, url;

            name = txtName.Text;
            bool allGoodToGo = true;
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("You must enter a name!");
                allGoodToGo = false;
            }

            if (string.IsNullOrWhiteSpace(txtBreed.Text))
            {
                MessageBox.Show("You must enter a breed!");
                allGoodToGo = false;
            }

            if (allGoodToGo == false)
            {
                return;
            }

            breed = txtBreed.Text;
            url = txtUrl.Text;

            Pet myPet = new Pet()
            {
                Breed = breed,
                Name = name,
                PicURL = url
            };
            //myPet.Name = name;

            lstPets.Items.Add(myPet);
            //lstPets.Items.Add(name); DONT DO THIS

        }

        private void lstPets_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            Pet selectedPet = (Pet)lstPets.SelectedItem;

            Uri locationOfImage = new Uri(selectedPet.PicURL);
            BitmapImage picFromInternet = new BitmapImage(locationOfImage);

            picPet.Source = picFromInternet;
        }
    }
}
