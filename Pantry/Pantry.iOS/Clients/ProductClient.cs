using System.Net;
using Newtonsoft.Json;
using Pantry.Clients;
using Pantry.iOS.Clients;
using Pantry.iOS.Models;
using Pantry.Models;
using RestSharp;

[assembly: Xamarin.Forms.Dependency(typeof(ProductClient))]

namespace Pantry.iOS.Clients
{
  public class ProductClient : IProductClient
  {
    private string _baseUrl;
    private RestClient _client;

    public OpenFood GetOpenFood(string barcode)
    {
      _baseUrl = "https://us.openfoodfacts.org/api/v0/product/";
      _client = new RestClient(_baseUrl);
      _client.AddHandler("application/json", new CustomRestSharpJsonSerializer());
      _client.AddHandler("text/json", new CustomRestSharpJsonSerializer());
      _client.AddHandler("text/x-json", new CustomRestSharpJsonSerializer());
      _client.AddHandler("text/javascript", new CustomRestSharpJsonSerializer());
      _client.AddHandler("*+json", new CustomRestSharpJsonSerializer());
      _client.AddHandler("application/json; charset=utf-8", new CustomRestSharpJsonSerializer());

      RestRequest restRequest = new RestRequest($"{barcode}.json", Method.GET)
      {
        RequestFormat = DataFormat.Json,
        Timeout = 1000000,
        JsonSerializer = new CustomRestSharpJsonSerializer()
      };
      IRestResponse<Food> response = _client.Execute<Food>(restRequest);

      if (response.StatusCode != HttpStatusCode.OK)
      {
        return null;
      }

      Food data = response.Data;
      Food food = JsonConvert.DeserializeObject<Food>(response.Content);
      return ReturnDoof(data);
    }

    private OpenFood ReturnDoof(Food food)
    {
      return new OpenFood()
      {
        Code = food.Code,
        Status = food.Status,
        StatusVerbose = food.StatusVerbose,
        Product = new Pantry.Models.Product()
        {
          ProductName = food.Product?.Product_Name,
          Ingredients = food.Product?.Ingredients_Text
        }
      };
    }
  }
}