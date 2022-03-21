using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using appPoke2.Utils;
using SQLite;
using Plugin.Media;
namespace appPoke2.Repository
{
    public class PokemonRepository
    {
        SQLiteAsyncConnection connection;

        public string StatusMessage { get; set; }
        public PokemonRepository(string dpPath)
        {
            connection = new SQLiteAsyncConnection(dpPath);
            connection.CreateTableAsync<MyPokemon>();
        }
        public async Task AddNewPokemonAsync(string name, string descriptions,  String image)
        {
            int result = 0;

            try
            {
                result = await connection.InsertAsync(new MyPokemon { name = name, description = descriptions, image= image});

                StatusMessage = $"{result} pokemon ajouté : {name}, {descriptions}, {image}";
            }
            catch (Exception ex)
            {
                StatusMessage = $"Impossible d'ajouter le pokemon : {name}.\n {ex.Message}";
            }
        }
        public async Task<List<MyPokemon>> GetPokemonAsync()
        {
            try
            {
                return await connection.Table<MyPokemon>().ToListAsync();
            }
            catch (Exception ex)
            {
                StatusMessage = $"Impossible de recuperer la liste des pokemons {ex.Message}";
            }
            return new List<MyPokemon>();
        }
    
    }
}

