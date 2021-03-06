﻿using Newtonsoft.Json;
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

namespace WPF_JSON_RickAndMorty
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class CharacterInfoWindow : Window
    {
        public string URL { get; set; }
        public CharacterInfoWindow()
        {
            InitializeComponent();
        }

        public void SetImageSource(Character character)
        {
            imgPicture.Source = new BitmapImage(new Uri(character.image));
        }
    }
}
