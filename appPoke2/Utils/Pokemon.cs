using System;
using SQLite;
using System.Collections.Generic;
using System.Text;

namespace appPoke2.Utils
{
    [Table("")]
    public class Pokemon
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(100), Unique]
        public String name { get; set; }
        public String description { get; set; }
        public String image { get; set; }
    }
}
