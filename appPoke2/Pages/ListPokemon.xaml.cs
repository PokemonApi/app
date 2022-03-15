﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using appPoke2.Utils;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;
using appPoke2.ViewModel;

namespace appPoke2.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPokemon : ContentPage
    {
        //private ObservableCollection<Pokemon> pokemons;

        public ListPokemon()
        {
            InitializeComponent();
            BindingContext = ListViewPokemon.Instance;

        }

     
      

        private async void detail(object sender, SelectionChangedEventArgs e)
        {
            MyPokemon myPokemon = e.CurrentSelection.FirstOrDefault() as MyPokemon;

            (sender as CollectionView).SelectedItem = null; 
                await Navigation.PushAsync(new PokemonsDetail(myPokemon));
            
            
            
        }
        /*
                private async void OnNewButtonClicked(object sender, EventArgs e)
                {
                    statusMessage.Text = "";
                    await App.PokemonRepository.AddNewPokemonAsync(newPokemon.Text);

                    statusMessage.Text = App.PokemonRepository.StatusMessage;
                }

                private async void OnGetButtonClicked(object sender, EventArgs e)
                {
                    statusMessage.Text = "";

                    List<Pokemon> pokemons = await App.PokemonRepository.GetPokemonAsync();

                    foreach (var pokemon in pokemons)
                    {
                        Console.WriteLine($"{pokemon.Id} - {pokemon.name} - {pokemon.description} ");

                    }
                    statusMessage.Text = App.PokemonRepository.StatusMessage;

                }
            }*/
    }
}