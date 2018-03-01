using Pantry.Gateways;
using Pantry.Gateways.Interfaces;
using Pantry.Services.Interfaces;
using Unity;
using Xamarin.Forms;

namespace Pantry.Views
{
  public partial class App : Application
  {
    public UnityContainer Container { get; set; }

    public App()
    {
      InitializeComponent();
      Xamarin.Forms.DependencyService.Register<IItemGateway>();
      DependencyService.Register<IDeviceService>();
      Container = new UnityContainer();
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
