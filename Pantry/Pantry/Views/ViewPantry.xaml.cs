using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Pantry.Gateways.Interfaces;
using Pantry.Models;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace Pantry.Views
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class ViewPantry : ContentPage
  {
    public ObservableCollection<Item> Items { get; set; }

    public ViewPantry()
    {
      InitializeComponent();

      SQLiteConnection connection = DependencyService.Get<IDatabase>().Connection;
      Items = DependencyService.Get<IItemGateway>().GetItemsObservable(connection);

      MyListView.ItemsSource = Items;
    }

    async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
    {
      if (e.Item == null)
        return;

      await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

      //Deselect Item
      ((ListView)sender).SelectedItem = null;
    }
  }
}
