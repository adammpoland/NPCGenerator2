using NPCGenerator2.Data;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("MateSC-Regular.ttf", Alias = "mate")]

namespace NPCGenerator2
{

    public partial class App : Application
    {
        static CharacterDatabase database;

        public static CharacterDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new CharacterDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Notes.db2"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new CharactersPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
