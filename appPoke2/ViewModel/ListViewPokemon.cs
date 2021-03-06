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

            for (int i = 1; i <= 120; i++)
            {
                Pokemon pokemon = await Task.Run(() => pokeClient.GetResourceAsync<Pokemon>(i));
                PokemonSpecies pokemon1 = await Task.Run(() => pokeClient.GetResourceAsync(pokemon.Species));

                MyPokemon mypokemon = new MyPokemon();

                mypokemon.Id = i;

                mypokemon.name = pokemon.Name;

                mypokemon.types = pokemon.Types[0].Type.Name;
                if(pokemon.Types.Count > 1) mypokemon.types2 = pokemon.Types[1].Type.Name;

                mypokemon.image = pokemon.Sprites.FrontShiny;

                mypokemon.description = pokemon.Species.Name;

               if (pokemon.Abilities[0] != null) mypokemon.abilities1 = (pokemon.Abilities[0].Ability.Name);
               if (pokemon.Abilities.Count>1) mypokemon.abilities2 = (pokemon.Abilities[1].Ability.Name); 

                mypokemon.hp = pokemon.Stats[0].BaseStat;
                mypokemon.attackStats = pokemon.Stats[1].BaseStat;
                mypokemon.defenseStats = pokemon.Stats[2].BaseStat;
                mypokemon.specialAttackStats = pokemon.Stats[3].BaseStat;
                mypokemon.specialDefenseStats = pokemon.Stats[4].BaseStat;
                mypokemon.characteristic = pokemon1.FlavorTextEntries.Find((flavor) => flavor.Language.Name == "en").FlavorText;
                ListOfPokemon.Add(mypokemon);
            }

        }
    }
}
