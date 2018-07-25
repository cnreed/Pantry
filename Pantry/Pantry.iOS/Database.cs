using System;
using System.IO;
using Pantry.iOS;
using SQLite;

[assembly: Xamarin.Forms.Dependency(typeof(Database))]
namespace Pantry.iOS
{
    public class Database : IDatabase
    {
      private static string _path;
      private static SQLiteConnection _connection;

      public static string Path
      {
        get
        {
          if (_path == null)
          {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = System.IO.Path.Combine(docFolder, "..", "Library", "Pantry/Databases");
            if (!Directory.Exists(libFolder))
            {
              Directory.CreateDirectory(libFolder);
            }

            return $"{libFolder}\\Item.db";
          }

          return _path;
        }
      }

      SQLiteConnection IDatabase.Connection => Connection;

      string IDatabase.Path => Path;

      public static SQLiteConnection Connection => _connection ?? (_connection = new SQLiteConnection(Path,
                                              SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create |
                                              SQLiteOpenFlags.FullMutex, true));
    }
}
