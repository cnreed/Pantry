using Pantry.Gateways;
using Pantry.Gateways.Interfaces;
using Pantry.Services.Interfaces;
using Xamarin.Forms;

namespace Pantry.Views
{
  public partial class App : Application
  {

    public App()
    {
      InitializeComponent();
      Xamarin.Forms.DependencyService.Register<IItemGateway>();
      DependencyService.Register<IDeviceService>();
//      Container.RegisterType<IItemGateway, ItemGateway>();
      MainPage = new NavigationPage(new MainPage());
    }

    protected override void OnStart()
    {
      // Handle when your app starts
    }

    protected override void OnSleep()
    {
      // Handle when your app sleeps
    }

    protected override void OnResume()
    {
      // Handle when your app resumes
    }
  }
}
