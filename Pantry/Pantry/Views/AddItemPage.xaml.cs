using System;
using System.Collections.Generic;
using System.Linq;
using Pantry.Enums;
using Pantry.Gateways.Interfaces;
using Pantry.Models;
using Pantry.Services.Interfaces;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pantry.Views
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class AddItemPage : ContentPage
  {
    private string _foodTypeString;
    private string _placeStoredString;
    private DateTime? _expirationDatePicked;

    public AddItemPage()
    {
      InitializeComponent();
      List<EnumFoodType> enumFoodTypes = Enum.GetValues(typeof(EnumFoodType)).Cast<EnumFoodType>().ToList();
      foreach (EnumFoodType foodTypesKey in enumFoodTypes)
      {
        FoodTypePicker.Items.Add(foodTypesKey.ToString());
      }

      List<EnumPlaceStored> enumPlaceStoreds = Enum.GetValues(typeof(EnumPlaceStored)).Cast<EnumPlaceStored>().ToList();
      foreach (EnumPlaceStored enumPlaceStored in enumPlaceStoreds)
      {
        PlaceStoredPicker.Items.Add(enumPlaceStored.ToString());
      }
    }

    private void AddItemToPantry(object sender, EventArgs e)
    {
            Item item = new Item()
            {
                Barcode = BarcodeEntry.Text,
                FoodType = EnumFoodType.Water,
                IsFrozen = false,
                Name = ItemEntry.Text,
                PlaceStored = EnumPlaceStored.Cabinent,
                Quantity = Convert.ToInt32(QuantityEntry.Text),
                StorageLocation = "UNKNWN",
                ExpirationDate = _expirationDatePicked
      };

      SQLiteConnection connection = DependencyService.Get<IDatabase>().Connection;
            DependencyService.Get<IItemGateway>().InsertUpdateDatabase(connection, item);
            Navigation.PopAsync();
    }

    private void OnFoodTypeChosen(object sender, EventArgs e)
    {
      _foodTypeString = (string) FoodTypePicker.SelectedItem;
    }

    private void OnPlaceStoredChosen(object sender, EventArgs e)
    {
      _placeStoredString = (string) PlaceStoredPicker.SelectedItem;
    }

    private void ExpirationDateSelected(object sender, DateChangedEventArgs e)
    {
      
      _expirationDatePicked = ExpirationDatePicker.Date;
      if (_expirationDatePicked <= DateTime.Today.AddDays(-1))
      {
        DisplayAlert("Warning",
          "The Date selected indicates that this item has already expired. Please throw away the food or enter a new expiration date",
          "Okay");
      }
    }
  }
}