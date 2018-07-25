using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pantry.Gateways.Interfaces;
using Pantry.Services.Interfaces;
using Pantry.Views;
using SQLite;
using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;

namespace Pantry
{
  public partial class MainPage : ContentPage
  {
    public MainPage()
    {
      InitializeComponent();
      SQLiteConnection connection = DependencyService.Get<IDatabase>().Connection;
      if (!DependencyService.Get<IDeviceService>().ItemDbExists())
      {
        DependencyService.Get<IItemGateway>().CreateDatabase(connection);
      }

    }

    protected override void OnAppearing()
    {
      base.OnAppearing();
      if (Loading.IsRunning)
      {
        Loading.IsRunning = false;
        LoadingLabel.IsVisible = false;
      }
    }

    private void OnAddItem(object sender, EventArgs e)
    {
      Navigation.PushAsync(new Views.AddItemPage());
    }

    private void OnRemoveItem(object sender, EventArgs e)
    {
    }

    private void OnScanItem(object sender, EventArgs e)
    {
      ZXingScannerPage scannerPage = new ZXingScannerPage();
      scannerPage.OnScanResult += result =>
      {
        scannerPage.IsScanning = false;
        Device.BeginInvokeOnMainThread(async () =>
        {
          Loading.IsRunning = true;
          LoadingLabel.IsVisible = true;
          await Navigation.PopAsync();
//          await DisplayAlert("Scanner Barcode", result.Text, "Ok");
          ScanResultPage scanResultPage = new ScanResultPage(result.Text);
          //          scanResultPage.Barcode = result.Text;
          await Navigation.PushAsync(scanResultPage);
        });
      };
      Navigation.PushAsync(scannerPage);
    }

    private void OnViewPantry(object sender, EventArgs e)
    {
      Navigation.PushAsync(new ViewPantry());
    }
  }
}
