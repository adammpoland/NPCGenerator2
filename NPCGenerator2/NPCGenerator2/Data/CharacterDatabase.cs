using System.Collections.Generic;
using System.Threading.Tasks;
using NPCGenerator2.Models;
using SQLite;


namespace NPCGenerator2.Data
{
    public class CharacterDatabase
    {
        readonly SQLiteAsyncConnection _database;

        public CharacterDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Character>().Wait();
        }

        public Task<List<Character>> GetNotesAsync()
        {
            return _database.Table<Character>().ToListAsync();
        }

        public Task<Character> GetNoteAsync(int id)
        {
            return _database.Table<Character>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveNoteAsync(Character character)
        {
            if (character.ID != 0)
            {
                return _database.UpdateAsync(character);
            }
            else
            {
                return _database.InsertAsync(character);
            }
        }

        public Task<int> DeleteNoteAsync(Character character)
        {
            return _database.DeleteAsync(character);
        }
    }
}