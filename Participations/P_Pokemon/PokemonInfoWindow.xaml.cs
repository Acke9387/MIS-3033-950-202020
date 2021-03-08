using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace P_Pokemon
{
    /// <summary>
    /// Interaction logic for PokemonInfoWindow.xaml
    /// </summary>
    public partial class PokemonInfoWindow : Window
    {
        public PokemonInfoAPI PokeInfo { get; set; }

        private bool ShouldIShowTheFront { get; set; }

        public PokemonInfoWindow()
        {
            InitializeComponent();
        }

        public void PopulateForm(PokemonInfoAPI pokeInfo)
        {
            imgPokemon.Source = new BitmapImage(new Uri(pokeInfo.squigglyWorm.front_default));
            lblTitle.Content = pokeInfo.name;
            lblHeight.Content = $"Height: {pokeInfo.height}";
            lblWeight.Content = $"Weight: {pokeInfo.weight}";
            ShouldIShowTheFront = false;
            PokeInfo = pokeInfo;
        }

        private void btnDance_Click(object sender, RoutedEventArgs e)
        {
            if (ShouldIShowTheFront == true)
            {
                imgPokemon.Source = new BitmapImage(new Uri(PokeInfo.squigglyWorm.front_default));
                //ShouldIShowTheFront = false;
            }
            else
            {
                imgPokemon.Source = new BitmapImage(new Uri(PokeInfo.squigglyWorm.back_default));
                //ShouldIShowTheFront = true;
            }
            ShouldIShowTheFront = !ShouldIShowTheFront;
        }
    }
}
