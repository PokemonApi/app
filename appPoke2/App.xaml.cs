using System;
using System.IO;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using appPoke2.Repository;

namespace appPoke2
{
    public partial class App : Application
    {
        string dbPath = Path.Combine(FileSystem.AppDataDirectory, "database.db");
       public static PokemonRepository PokemonRepository { get; set; }
        public App()
        {
            InitializeComponent();

            PokemonRepository = new PokemonRepository(dbPath);

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
