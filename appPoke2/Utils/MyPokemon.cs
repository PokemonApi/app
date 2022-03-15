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

        public String characteristic { get; set; }  
        public int attackStats { get; set; }
        public int defenseStats { get; set; }
        public int specialAttackStats { get; set; }
        public int specialDefenseStats { get; set; }
        public int hp { get; set; }
        public String abilities1 { get; set; }
        public String abilities2 { get; set; }
        public String image { get; set; }
    }
}
