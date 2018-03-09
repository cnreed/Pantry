using System;
using System.Collections.Generic;
using System.Security.Policy;
using RestSharp.Deserializers;

namespace Pantry.iOS.Models
{
  public class Product
  {

//    [DeserializeAs(Name = "nutrient_levels")]
//    public object NutrientLevels { get; set; }

    [DeserializeAs(Name = "code")] public string Barcode { get; set; }

    [DeserializeAs(Name = "id")] public string Id { get; set; }

    [DeserializeAs(Name = "last_modified_by")]
    public string LastModifiedBy { get; set; }

    [DeserializeAs(Name = "additives")] public string Additives { get; set; }

    [DeserializeAs(Name = "serving_size")]
    public string ServingSize { get; set; }

    [DeserializeAs(Name = "_keywords")]
    public IList<string> Keywords { get; set; }

    [DeserializeAs(Name = "complete")]
    public string Complete { get; set; }

  
    public String Product_Name { get; set; }

//    [DeserializeAs(Name = "states")] public string States { get; set; }
//    [DeserializeAs(Name = "brands")] public string Brands { get; set; }
//
//    [DeserializeAs(Name = "nutrition_data_per")]
//    public string NutritionDataPer { get; set; }
//
//    [DeserializeAs(Name = "allergens")] public string Allergens { get; set; }
//
//    [DeserializeAs(Name = "last_modified_t")]
//    public DateTime? LastModified { get; set; }

//    [DeserializeAs(Name = "ingredients")] public IList<object> Ingredients { get; set; }

//    [DeserializeAs(Name = "checkers_tags")]
//    public IList<string> CheckersTags { get; set; }
//
//    [DeserializeAs(Name = "ingredients_debug")]
//    public IList<string> IngredientsDebug { get; set; }
//
//    [DeserializeAs(Name = "additives_prev_tags")]
//    public IList<string> AdditivesPreviousTags { get; set; }

//    [DeserializeAs(Name = "nutriments")] public object Nutriments { get; set; }
    [DeserializeAs(Name = "created_t")] public DateTime Created { get; set; }

    [DeserializeAs(Name = "serving_quantity")]
    public int ServingQuantity { get; set; }

//    [DeserializeAs(Name = "sources")] public object Sources { get; set; }

    [DeserializeAs(Name = "_id")] public string IdBarcode { get; set; }
  }
}
