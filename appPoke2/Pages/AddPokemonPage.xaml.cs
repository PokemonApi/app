using appPoke2.ViewModel;
using PokeApiNet;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace appPoke2.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddPokemonPage : ContentPage
    {
        public AddPokemonPage()
        {
            InitializeComponent();
            

        
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            


            PokeApiClient poke = new PokeApiClient();
            for (int i = 1; i < 101; i++)
            {

                Pokemon pokemon = await Task.Run(()=> poke.GetResourceAsync<Pokemon>(i));

                Debug.WriteLine(pokemon.Name);
                
            }
           
            
        }

        

        public PokeApiClient PokeApiClient { get; }
    }
}