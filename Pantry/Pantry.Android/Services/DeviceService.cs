using Pantry.Droid.Services;
using Pantry.Services.Interfaces;

[assembly: Xamarin.Forms.Dependency(typeof(DeviceService))]
namespace Pantry.Droid.Services
{
    public class DeviceService : IDeviceService
    {
        public string CreateDatabasePath(string fileName)
        {
            return null;
        }
    }
}