using PokeApiNet;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace appPoke2.ViewModel
{
    internal class ListViewPokemon : BaseViewModel
    {
         
        private static ListViewPokemon _instance = new ListViewPokemon();
        public static ListViewPokemon Instance { get { return _instance; } }
        public ObservableCollection<Pokemon> ListOfPokemon
        {
            get=> GetValue<ObservableCollection<Pokemon>>();
               
            set => SetValue(value);
            
        }

    }
}
