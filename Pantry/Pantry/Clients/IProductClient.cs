using Pantry.Models;

namespace Pantry.Clients
{
  public interface IProductClient
  {
    OpenFood GetOpenFood(string barcode);

//    string HelloWorld();
  }
}