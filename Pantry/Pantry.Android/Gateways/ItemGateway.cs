using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Pantry.Droid.Gateways;
using Pantry.Gateways.Interfaces;
using Pantry.Models;
using SQLite;

[assembly: Xamarin.Forms.Dependency(typeof(ItemGateway))]
namespace Pantry.Droid.Gateways
{

    public class ItemGateway : IItemGateway
    {
    public void CreateDatabase(SQLiteConnection connection)
      {

        connection.CreateTable<Item>();

      }

      public int InsertUpdateDatabase(SQLiteConnection connection, Item item)
      {

        int id = connection.Insert(item);
        if (id != 0)
        {
          return id;
        }


        return 0;
      }

      public IList<Item> GetItems(SQLiteConnection connection)
      {

        TableQuery<Item> itemQuery = from item in connection.Table<Item>() select item;
        return itemQuery.ToList();

      }

      public IList<Item> GetItems(SQLiteConnection connection, string name)
      {

        TableQuery<Item> itemQuery = from item in connection.Table<Item>() where item.Name.Contains(name) select item;
        return itemQuery.ToList();

      }

      public ObservableCollection<Item> GetItemsObservable(SQLiteConnection connection)
      {
        ObservableCollection<Item> items = new ObservableCollection<Item>();
        TableQuery<Item> itemQuery = from item in connection.Table<Item>() select item;
        List<Item> list = itemQuery.ToList();
        list.ForEach(item => items.Add(item));
        return items;
      }

    public Item GetItem(SQLiteConnection connection, string barcode)
      {

        TableQuery<Item> itemQuery = from item in connection.Table<Item>() where item.Barcode == barcode select item;
        if (itemQuery.ToList().Count == 0)
        {
          return null;
        }
        else
        {
          return itemQuery.ToList()[0];
        }

      }
  }
}