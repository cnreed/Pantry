using Pantry.Models;

namespace Pantry.Clients
{
  public interface IProductClient
  {
    Doof GetOpenFood(string barcode);

    string HelloWorld();
  }
}