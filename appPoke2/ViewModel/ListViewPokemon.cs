using appPoke2.Utils;
using PokeApiNet;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace appPoke2.ViewModel
{
    internal class ListViewPokemon : BaseViewModel
    {
         
        private static ListViewPokemon _instance = new ListViewPokemon();
        public static ListViewPokemon Instance { get { return _instance; } }
        public ObservableCollection<MyPokemon> ListOfPokemon
        {
            get=> GetValue<ObservableCollection<MyPokemon>>();
               
            set => SetValue(value);
            
        }

        public ListViewPokemon()
        {

            ListOfPokemon = new ObservableCollection<MyPokemon>();

            InitList();

        }

        public async void InitList()
        {
            PokeApiClient pokeClient = new PokeApiClient();

            for (int i = 1; i <= 20; i++)
            {
                Pokemon pokemon = await Task.Run(() => pokeClient.GetResourceAsync<Pokemon>(i));
                MyPokemon mypokemon = new MyPokemon();

                mypokemon.Id = i;
                mypokemon.name = pokemon.Name;
                mypokemon.types = pokemon.Types[0].Type.Name;
                mypokemon.image = pokemon.Sprites.FrontShiny;
                mypokemon.description = pokemon.Species.Name;

                ListOfPokemon.Add(mypokemon);
            }

        }
    }
}
