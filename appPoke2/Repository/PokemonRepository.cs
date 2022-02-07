﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using appPoke2.Utils;
using SQLite;
namespace appPoke2.Repository
{
    public class PokemonRepository
    {
        SQLiteAsyncConnection connection;

        public string StatusMessage { get; set; }
        public PokemonRepository(string dpPath)
        {
            connection = new SQLiteAsyncConnection(dpPath);
            connection.CreateTableAsync<Pokemon>();
        }
        public async Task AddNewPokemonAsync(string name)
        {
            int result = 0;

            try
            {
                result = await connection.InsertAsync(new Pokemon { name = name });

                StatusMessage = $"{result} pokemon ajouté : {name}";
            }
            catch (Exception ex)
            {
                StatusMessage = $"Impossible d'ajouter le pokemon : {name}.\n {ex.Message}";
            }
        }
        public async Task<List<Pokemon>> GetPokemonAsync()
        {
            try
            {
                return await connection.Table<Pokemon>().ToListAsync();
            }
            catch (Exception ex)
            {
                StatusMessage = $"Impossible de recuperer la liste des pokemons {ex.Message}";
            }
            return new List<Pokemon>();
        }
    
    }
}

