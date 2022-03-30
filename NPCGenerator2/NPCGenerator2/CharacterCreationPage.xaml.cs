using NPCGenerator2;
using NPCGenerator2.Helpers;
using NPCGenerator2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace NPCGenerator2
{
    public partial class CharacterCreationPage : ContentPage
    {
        public CharacterCreationPage()
        {
           InitializeComponent();
        }


        void OnRandomizeButtonClicked(object sender, EventArgs e)
        {
            Random rnd = new Random();
            List<string> humanFirstNames = new List<string>() { "Anlow", "Arando", "Bram", "Cale", "Dalkon", "Daylen", "Dodd", "Dungarth", "Dyrk", "Eandro", "Falken", "Feck", "Fenton", "Gryphero", "Hagar", "Jeras", "Krynt", "Lavant", "Leyten", "Madian", "Malfier", "Markus", "Meklan", "Namen", "Navaren", "Nerle", "Nilus", "Ningyan", "Norris", "Quentin", "Semil", "Sevenson", "Steveren", "Talfen", "Tamond", "Taran", "Tavon", "Tegan", "Vanan","Vincent" };
            List<string> humanLastNames = new List<string>() { "Arkalis", "Armanci", "Bilger", "Blackstrand", "Brightwater", "Carnavon", "Caskajaro", "Coldshore", "Coyle", "Cresthill", "Cuttlescar", "Daargen", "Dalicarlia", "Danamark", "Donoghan", "Drumwind", "Dunhall", "Ereghast", "Falck", "Fallenbridge", "Faringray", "Fletcher", "Fryft", "Goldrudder", "Grantham", "Graylock", "Gullscream", "Hindergrass", "Iscalon", "Kreel", "Kroft", "Lamoth", "Leerstrom", "Lynchfield", "Moonridge", "Netheridge", "Oakenheart", "Pyncion", "Ratley", "Redraven", "Revenmar", "Roxley", "Sell", "Seratolva", "Shanks", "Shattermast", "Shaulfer", "Silvergraft", "Stavenger", "Stormchapel", "Strong", "Swiller", "Talandro", "Targana", "Towerfall", "Umbermoor", "Van Devries", "Van Gandt", "Van Hyden", "Varcona", "Varzand", "Voortham", "Vrye", "Webb", "Welfer", "Wilxes", "Wintermere", "Wygarthe", "Zatchet", "Zethergyll" };


            List<string> ages= new List<string>() { "Young", "Teenager", "Young Adult", "Adult" , "Old" };

            List<string> races = new List<string>() { "Human", "Orc", "Tiefling", "Dragonborn", "Dwarf","Elf","Gnome","Half-Elf","Halfling" };
            List<string> classes = new List<string>() { "Barbarian", "Bard", "Cleric", "Druid", "Fighter", "Monk", "Paladin", "Ranger", "Rogue", "Sorcerer", "Warlock", "Wizard" };

            List<string> dwarfFirstNames = new List<string>() { "Adra", "Annar", "Bardryn", "Barra", "Bellana", "Braelyn", "Burra", "Fullarra", "Gadira", "Jarra", "Kessa", "Nidar", "Adrik", "Adward", "Baern", "Balan", "Cagnar", "Darbittur", "Eberk", "Erill", "Etward", "Fasil", "Gardain", "Gisbourne", "Glint", "Ghorvas", "Grimmalk", "Haeltar", "Halagmar", "Halzar", "Hlant", "Korlag", "Krag", "Krim", "Kurman", "Lurtrum", "Malagar", "Mardam", "Maulnar", "Melgar", "Morak", "Orobok", "Rogath", "Roken", "Rozag", "Sabakzar", "Sharak", "Smethykk", "Swargar", "Thorbalt", "Thorin", "Tredigar", "Vabûl", "Vistrum", "Wolva" };
            List<string> dwarfLastNames = new List<string>() { "Ambershard", "Barrelhelm", "Copperhearth", "Deepmiddens", "Drakantal", "Evermead", "Garkalan", "Grimtor", "Hackshield", "Irongull", "Markolak", "Ramcrown", "Rockharvest", "Silvertarn","Skandalor", "Zarkanan" };



            List<string> elfFirstNames = new List<string>() { "Aryllan", "Atalya", "Ayrthwil", "Irva", "Lyfalia", "Ronefel", "Thirya", "Velene", "Venefiq", "Zereni" ,"Adrie", "Airwen", "Brea", "Bariela", "Cefa", "Chandrelle", "Dariena", "Elenwe", "Fiona", "Gaia", "Grainne", "Guda","Alarcion", "Alathar", "Ariandar", "Arromar", "Borel", "Bvachan", "Carydion", "Elgoth", "Farlien", "Ferel", "Gaerlan", "Iafalior", "Kaelthorn", "Laethan", "Leliar", "Leodor", "Lorak", "Lorifir", "Morian", "Oleran", "Rylef", "Savian", "Seylas", "Tevior","Veyas" };
            List<string> elfLastNames = new List<string>() { "Autumnloft", "Balefrost", "Briarfell", "Evenwind", "Graytrails", "Mooncairn", "Riverwall", "Stormwolf", "Summergale", "Sunshadow", "Woodenhawk" };

            List<string> AllFirstNames = new List<string>() { "Anlow", "Arando", "Bram", "Cale", "Dalkon", "Daylen", "Dodd", "Dungarth", "Dyrk", "Eandro", "Falken", "Feck", "Fenton", "Gryphero", "Hagar", "Jeras", "Krynt", "Lavant", "Leyten", "Madian", "Malfier", "Markus", "Meklan", "Namen", "Navaren", "Nerle", "Nilus", "Ningyan", "Norris", "Quentin", "Semil", "Sevenson", "Steveren", "Talfen", "Tamond", "Taran", "Tavon", "Tegan", "Vanan", "Vincent" , "Adra", "Annar", "Bardryn", "Barra", "Bellana", "Braelyn", "Burra", "Fullarra", "Gadira", "Jarra", "Kessa", "Nidar", "Adrik", "Adward", "Baern", "Balan", "Cagnar", "Darbittur", "Eberk", "Erill", "Etward", "Fasil", "Gardain", "Gisbourne", "Glint", "Ghorvas", "Grimmalk", "Haeltar", "Halagmar", "Halzar", "Hlant", "Korlag", "Krag", "Krim", "Kurman", "Lurtrum", "Malagar", "Mardam", "Maulnar", "Melgar", "Morak", "Orobok", "Rogath", "Roken", "Rozag", "Sabakzar", "Sharak", "Smethykk", "Swargar", "Thorbalt", "Thorin", "Tredigar", "Vabûl", "Vistrum", "Wolva", "Aryllan", "Atalya", "Ayrthwil", "Irva", "Lyfalia", "Ronefel", "Thirya", "Velene", "Venefiq", "Zereni", "Adrie", "Airwen", "Brea", "Bariela", "Cefa", "Chandrelle", "Dariena", "Elenwe", "Fiona", "Gaia", "Grainne", "Guda", "Alarcion", "Alathar", "Ariandar", "Arromar", "Borel", "Bvachan", "Carydion", "Elgoth", "Farlien", "Ferel", "Gaerlan", "Iafalior", "Kaelthorn", "Laethan", "Leliar", "Leodor", "Lorak", "Lorifir", "Morian", "Oleran", "Rylef", "Savian", "Seylas", "Tevior", "Veyas" };
            List<string> AllLastNames = new List<string>() { "Arkalis", "Armanci", "Bilger", "Blackstrand", "Brightwater", "Carnavon", "Caskajaro", "Coldshore", "Coyle", "Cresthill", "Cuttlescar", "Daargen", "Dalicarlia", "Danamark", "Donoghan", "Drumwind", "Dunhall", "Ereghast", "Falck", "Fallenbridge", "Faringray", "Fletcher", "Fryft", "Goldrudder", "Grantham", "Graylock", "Gullscream", "Hindergrass", "Iscalon", "Kreel", "Kroft", "Lamoth", "Leerstrom", "Lynchfield", "Moonridge", "Netheridge", "Oakenheart", "Pyncion", "Ratley", "Redraven", "Revenmar", "Roxley", "Sell", "Seratolva", "Shanks", "Shattermast", "Shaulfer", "Silvergraft", "Stavenger", "Stormchapel", "Strong", "Swiller", "Talandro", "Targana", "Towerfall", "Umbermoor", "Van Devries", "Van Gandt", "Van Hyden", "Varcona", "Varzand", "Voortham", "Vrye", "Webb", "Welfer", "Wilxes", "Wintermere", "Wygarthe", "Zatchet", "Zethergyll", "Ambershard", "Barrelhelm", "Copperhearth", "Deepmiddens", "Drakantal", "Evermead", "Garkalan", "Grimtor", "Hackshield", "Irongull", "Markolak", "Ramcrown", "Rockharvest", "Silvertarn", "Skandalor", "Zarkanan" , "Autumnloft", "Balefrost", "Briarfell", "Evenwind", "Graytrails", "Mooncairn", "Riverwall", "Stormwolf", "Summergale", "Sunshadow", "Woodenhawk" };


            string class1 = classes[rnd.Next(0, classes.Count)];
            Class.Text = class1;

            string race = races[rnd.Next(0, races.Count)];
            Race.Text = race;

            string age = ages[rnd.Next(0, ages.Count)];
            Age1.Text = age;

            string fullName = AllFirstNames[rnd.Next(0, AllFirstNames.Count)] + " " + AllLastNames[rnd.Next(0, AllLastNames.Count)];
            Name.Text = fullName;

            
            Strength.Text = GetModifier(GetAtribute()).ToString();
            Dexterity.Text = GetModifier(GetAtribute()).ToString();
            Intelligence.Text = GetModifier(GetAtribute()).ToString();
            Constitution.Text = GetModifier(GetAtribute()).ToString();
            Wisdom.Text = GetModifier(GetAtribute()).ToString();
            Charisma.Text = GetModifier(GetAtribute()).ToString();

        }

        private int GetAtribute()
        {
            Dice die1 = new Dice(6);
            Dice die2 = new Dice(6);
            Dice die3 = new Dice(6);
            Dice die4 = new Dice(6);
            int sum = 0;


            List<int> Rolls = new List<int>();
            Rolls.Add(die1.Roll());
            Rolls.Add(die2.Roll());
            Rolls.Add(die3.Roll());
            Rolls.Add(die4.Roll());

            for(int i = 0; i < Rolls.Count;i++)
            {
                if (Rolls[i] == Rolls.Min())
                {
                    Rolls.RemoveAt(i);
                    break;
                }

            }

            
            for (int i = 0; i < Rolls.Count; i++)
            {
                sum += Rolls[i];
            }

            return sum;
        }

        private int GetModifier(int sum)
        {
            if (sum == 1)
            {
                return -5;
            }else if (sum == 2 || sum == 3)
            {
                return -4;
            }
            else if (sum == 4 || sum == 5)
            {
                return -3;
            }
            else if (sum == 6 || sum == 7)
            {
                return -2;
            }
            else if (sum == 8 || sum == 9)
            {
                return -1;
            }
            else if (sum == 10 || sum == 11)
            {
                return 0;
            }
            else if (sum == 12 || sum == 13)
            {
                return 1;
            }
            else if (sum == 14 || sum == 15)
            {
                return 2;
            }
            else if (sum == 16 || sum == 17)
            {
                return 3;
            }
            else
            {
                return 4;
            }
        }


        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
          

            var note = (Character)BindingContext;
            note.Date = DateTime.UtcNow;
            await App.Database.SaveNoteAsync(note);
            await Navigation.PopAsync();
        }

        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var note = (Character)BindingContext;
            await App.Database.DeleteNoteAsync(note);
            await Navigation.PopAsync();
        }

        
    }
}