using System;
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
            if (myPokemon == null)
            {
                return;
            }

            (sender as CollectionView).SelectedItem = null; 
                await Navigation.PushAsync(new PokemonsDetail(myPokemon));
            
            
            
        }
        
              
    }
}