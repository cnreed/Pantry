namespace Pantry.Services.Interfaces
{
  public interface IDeviceService
  {
    string CreateDatabasePath(string fileName);
    bool ItemDbExists();
  }
}