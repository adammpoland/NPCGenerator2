using System;
using SQLite;

namespace NPCGenerator2.Models
{
    public class Character
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string Level { get; set; }
        public string Race { get; set; }
        public string Age1 { get; set; }
        public string ArmorClass { get; set; }
        public string CurrentHitPoints { get; set; }
        public string MaxHitPoints { get; set; }
        public string Strength { get; set; }
        public string Dexterity { get; set; }
        public string Constitution { get; set; }
        public string Intelligence { get; set; }
        public string Wisdom { get; set; }
        public string Charisma { get; set; }
        public DateTime Date { get; set; }
    }
}