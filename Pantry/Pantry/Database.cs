using System;
using SQLite;

namespace Pantry
{
    public class Database
    {
        private string _path;
        public string Path { get; }
        public SQLiteConnection Connection { get; }
        private SQLiteConnection _connection { get; }
    }
}
