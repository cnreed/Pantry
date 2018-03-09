using System.Collections.Generic;
using RestSharp.Deserializers;

namespace Pantry.iOS.Models
{
  public class Sources
  {
    [DeserializeAs(Name = "id")]
    public string Id { get; set; }
    [DeserializeAs(Name = "url")]
    public string Url { get; set; }
    [DeserializeAs(Name = "fields")]
    public IList<string> Fields { get; set; }
    [DeserializeAs(Name = "import_t")]
    public string Import { get; set; }
    [DeserializeAs(Name = "images")]
    public IList<object> Images { get; set; }
    
  }
}