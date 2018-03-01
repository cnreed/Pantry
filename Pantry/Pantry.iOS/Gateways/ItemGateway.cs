using System.Collections.Generic;
using System.Linq;
using Pantry.Gateways.Interfaces;
using Pantry.iOS.Gateways;
using Pantry.Models;
using SQLite;

[assembly: Xamarin.Forms.Dependency(typeof(ItemGateway))]
namespace Pantry.iOS.Gateways
{

  public class ItemGateway : IItemGateway
  {
    public void CreateDatabase(string path)
    {
      using (SQLiteConnection connection = new SQLiteConnection(path))
      {
        connection.CreateTable<Item>();
      }
    }

    public int InsertUpdateDatabase(string databasePath, Item item)
    {
      using (SQLiteConnection connction = new SQLiteConnection(databasePath))
      {
        int id = connction.Insert(item);
        if (id != 0)
        {
          return id;
        }
      }

      return 0;
    }

    public IList<Item> GetItems(string databasePath)
    {
      using (SQLiteConnection connection = new SQLiteConnection(databasePath))
      {
        TableQuery<Item> itemQuery = from item in connection.Table<Item>() select item;
        return itemQuery.ToList();
      }
    }

    public IList<Item> GetItems(string databasePath, string name)
    {
      using (SQLiteConnection connection = new SQLiteConnection(databasePath))
      {
        TableQuery<Item> itemQuery = from item in connection.Table<Item>() where item.Name.Contains(name) select item;
        return itemQuery.ToList();
      }
    }

    public Item GetItem(string databasePath, string barcode)
    {
      using (SQLiteConnection connection = new SQLiteConnection(databasePath))
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
}