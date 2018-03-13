using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pantry.Clients;
using Pantry.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pantry.Views
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class ScanResultPage : ContentPage
  {

    public ScanResultPage(string barcode)
    {
      InitializeComponent();
      BarcodeLabel.Text = "Barcode Text: " + barcode;
      OpenFood openFood = DependencyService.Get<IProductClient>().GetOpenFood(barcode);
      ProductNameLabel.Text = "Is this your product? " + openFood.Product?.ProductName;
      IngredientsLabel.Text = "Ingredients: " + openFood.Product?.Ingredients;
    }

    private void YesButtonOnCliecked(object sender, EventArgs e)
    {
      AddItemPage addItem = new AddItemPage();
      Navigation.PushAsync(addItem);
    }

    private void NoButtonOnClicked(object sender, EventArgs e)
    {
      Navigation.PopAsync();
    }
  }
}