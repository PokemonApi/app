using appPoke2.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace appPoke2.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PokemonsDetail : ContentPage
    {
        public PokemonsDetail(MyPokemon pokemon)
        {
            InitializeComponent();
            BindingContext = pokemon;
        }      
    }
}