using RestSharp.Deserializers;

namespace Pantry.OpenFood.Models
{
  public class OpenFood
  {
    
    [DeserializeAs(Name = "product")]
    public Product Product { get; set; }
    [DeserializeAs(Name = "status_verbose")]
    public string StatusVerbose { get; set; }
    [DeserializeAs(Name = "status")]
    public int Status { get; set; }
    [DeserializeAs(Name = "code")]
    public long Code { get; set; }
  }
}