using System;
using System.Collections.Generic;
using Pantry.Models;
using Xamarin.Forms;

namespace Pantry.Views
{
  public partial class ViewItem : ContentPage
  {
    public ViewItem(Item item)
    {
      InitializeComponent();
      ItemName.Text = item.Name;
      ItemQuantity.Text = item.Quantity.ToString();
      ItemBarcode.Text = item.Barcode;
      ItemExpirationDate.Text = item.ExpirationDate.ToString();
    }
  }
}
