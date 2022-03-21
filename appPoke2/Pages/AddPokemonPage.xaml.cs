using appPoke2.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Media;
using Plugin.Media.Abstractions;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace appPoke2.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddPokemonPage : ContentPage
    {
        private Image image1;

        public AddPokemonPage()
        {
            InitializeComponent();
            

        
        }
        private async void OnTakePicture(object sender, EventArgs e)
        {
            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                await DisplayAlert("Impossible","Votre appareil ne prend pas en charge l'upload","Arret");
                return;
            }
            var file = await CrossMedia.Current.PickPhotoAsync();
            if (file == null) { return;
                image1.Source = ImageSource.FromStream(() => file.GetStream());
            }
        }
        private async void OnNewButtonClicked(object sender, EventArgs e)
        {
            statusMessage.Text = "";
            await App.PokemonRepository.AddNewPokemonAsync(newPokemon.Text, newDescriptions.Text, newImage.Image);

            statusMessage.Text = App.PokemonRepository.StatusMessage;
        }

        private async void OnGetButtonClicked(object sender, EventArgs e)
        {
            statusMessage.Text = "";

            List<Utils.MyPokemon> pokemons = await App.PokemonRepository.GetPokemonAsync();

            foreach (var pokemon in pokemons)
            {
                Console.WriteLine($"{pokemon.Id} - {pokemon.name} - {pokemon.description} - {pokemon.image}");

            }
            statusMessage.Text = App.PokemonRepository.StatusMessage;

        }
    }
}