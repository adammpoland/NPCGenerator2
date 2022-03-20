using NPCGenerator2.Models;
using System;
using Xamarin.Forms;

namespace NPCGenerator2
{
    public partial class CharactersPage : ContentPage
    {
        public CharactersPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            lvCharacters.ItemsSource = await App.Database.GetNotesAsync();
        }

        async void OnNoteAddedClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CharacterCreationPage
            {
                BindingContext = new Character()

            });
        }

        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new CharacterCreationPage
                {
                    BindingContext = e.SelectedItem as Character
                });
            }
        }
    }
}