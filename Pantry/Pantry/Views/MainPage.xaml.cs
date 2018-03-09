using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pantry.Views;
using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;

namespace Pantry
{
  public partial class MainPage : ContentPage
  {
    public MainPage()
    {
      InitializeComponent();
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
          await Navigation.PopAsync();
//          await DisplayAlert("Scanner Barcode", result.Text, "Ok");
          ScanResultPage scanResultPage = new ScanResultPage(result.Text);
          //          scanResultPage.Barcode = result.Text;
          await Navigation.PushAsync(scanResultPage);
        });
      };
      Navigation.PushAsync(scannerPage);
    }
  }
}
