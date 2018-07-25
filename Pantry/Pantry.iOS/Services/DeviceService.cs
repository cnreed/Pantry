using System;
using System.IO;
using Pantry.iOS.Services;
using Pantry.Services.Interfaces;

[assembly:Xamarin.Forms.Dependency(typeof(DeviceService))]
namespace Pantry.iOS.Services
{
  public class DeviceService : IDeviceService
  {
    public string CreateDatabasePath(string fileName)
    {
      string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
      string libFolder = Path.Combine(docFolder, "..", "Library", "Pantry/Databases");
      if (!PathExists(libFolder))
      {
        Directory.CreateDirectory(libFolder);

      }
      return Path.Combine(libFolder, fileName);
    }

    public bool ItemDbExists()
    {
      return File.Exists(Database.Path);
    }

    public bool PathExists(string path)
    {
      return Directory.Exists(path);

    }
  }
}