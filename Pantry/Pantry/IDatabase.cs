using System;
using SQLite;

namespace Pantry
{
  public interface IDatabase
  {
    string Path { get; }
    SQLiteConnection Connection { get; }
  
  }
}
