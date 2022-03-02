using System;
using SQLite;
using System.Collections.Generic;
using System.Text;
using PokeApiNet;

namespace appPoke2.Utils
{
    [Table("")]
    public class MyPokemon
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(100), Unique]
        public String name { get; set; }
        public String description { get; set; }
        public String types { get; set; }
        public String types2 { get; set; }


        public List<PokemonAbility> abilities { get; set; }
        public String image { get; set; }
    }
}
