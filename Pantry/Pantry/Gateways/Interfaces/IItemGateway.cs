using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pantry.Models;

namespace Pantry.Gateways.Interfaces
{
    public interface IItemGateway
    {
        void CreateDatabase(string path);
        int InsertUpdateDatabase(string databasePath, Item item);
        IList<Item> GetItems(string databasePath);
        IList<Item> GetItems(string databasePath, string name);
        Item GetItem(string databasePath, string barcode);
        
    }
}
