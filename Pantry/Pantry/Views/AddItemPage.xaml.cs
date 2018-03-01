using System;
using System.Collections.Generic;
using Pantry.Enums;
using Pantry.Gateways.Interfaces;
using Pantry.Services.Interfaces;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pantry.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddItemPage : ContentPage

    {
        public Dictionary<string, EnumFoodType> FoodTypes = new Dictionary<string, EnumFoodType>()
        {
            {"Fruit", EnumFoodType.Fruit },
            {"Vegetables", EnumFoodType.Vegetable },
            {"Canned", EnumFoodType.Canned },
            {"Juice", EnumFoodType.Juice },
            {"Soda", EnumFoodType.Soda },
            {"Water", EnumFoodType.Water },
            {"Candy", EnumFoodType.Candy },
            {"Pasta", EnumFoodType.Pasta },
            {"Bread", EnumFoodType.Bread },
            {"Cereal", EnumFoodType.Cereal }
        };
        public AddItemPage()
        {
            InitializeComponent();
            foreach (string foodTypesKey in FoodTypes.Keys)
            {
                FoodTypePicker.Items.Add(foodTypesKey);
            }
        }

        private void AddItemToPantry(object sender, EventArgs e)
        {
          string databasePath = DependencyService.Get<IDeviceService>().CreateDatabasePath("Item.db");
          DependencyService.Get<IItemGateway>().CreateDatabase(databasePath);
        }

        private void OnFoodTypeChosen(object sender, EventArgs e)
        {
            string selectedItem = (string)FoodTypePicker.SelectedItem;
        }
    }
}