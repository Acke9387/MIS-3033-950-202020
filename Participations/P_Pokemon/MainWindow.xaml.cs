using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace P_Pokemon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string url = "https://pokeapi.co/api/v2/pokemon/?limit=1200";
            AllPokemonAPI api;// = new AllPokemonAPI(); ;

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(url).Result;

                // Use if you need to validate that it was successful

                var result = client.GetStringAsync(url).Result;

                api = JsonConvert.DeserializeObject<AllPokemonAPI>(result);

            }


            foreach (ResultObject result in api.results.OrderBy(x => x.name).ToList())
            {
                lstPokemon.Items.Add(result);
            }

        }

        private void lstPokemon_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ResultObject selectedPokemon = (ResultObject)lstPokemon.SelectedItem;

            PokemonInfoAPI pokeInfo;

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(selectedPokemon.url).Result;

                pokeInfo = JsonConvert.DeserializeObject<PokemonInfoAPI>(json);
            }

            PokemonInfoWindow wnd = new PokemonInfoWindow();
            wnd.PopulateForm(pokeInfo);
            wnd.ShowDialog();


        }
    }
}
