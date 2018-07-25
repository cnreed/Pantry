using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pantry.Models;
using SQLite;

namespace Pantry.Gateways.Interfaces
{
    public interface IItemGateway
    {
        void CreateDatabase(SQLiteConnection connection);
        int InsertUpdateDatabase(SQLiteConnection connection, Item item);
        IList<Item> GetItems(SQLiteConnection connection);
        IList<Item> GetItems(SQLiteConnection connection, string name);
        Item GetItem(SQLiteConnection connection, string barcode);
        
    }
}
