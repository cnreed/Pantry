using System.Collections.Generic;

namespace Pantry.Models
{
  public class Sources
  {
    public string Id { get; set; }
    public string Url { get; set; }
    public IList<string> Fields { get; set; }
    public string Import { get; set; }

    public IList<object> Images { get; set; }
    
  }
}