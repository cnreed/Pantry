using System;
using System.Collections.Generic;
using System.Security.Policy;
using RestSharp.Deserializers;

namespace Pantry.iOS.Models
{
  public class Product
  {
    [DeserializeAs(Name = "countries")] public string Countries { get; set; }

    [DeserializeAs(Name = "brands_debug_tags")]
    public IList<string> BrandsDebugTags { get; set; }

    [DeserializeAs(Name = "ingredients_text_en")]
    public string IngredientsTextEnglish { get; set; }

    [DeserializeAs(Name = "ingredients_that_may_be_from_palm_oil_tags")]
    public IList<string> IngredientsThatMayBeFromPalmOil { get; set; }

    [DeserializeAs(Name = "photographers_tags")]
    public IList<string> PhotographersTags { get; set; }

    [DeserializeAs(Name = "ingredients_text_debug")]
    public string IngredientsTextDebug { get; set; }

    [DeserializeAs(Name = "additives_debug_tags")]
    public IList<string> AdditivesDebugTags { get; set; }

    [DeserializeAs(Name = "countries_debug_tags")]
    public IList<string> CountriesDebugTags { get; set; }

    [DeserializeAs(Name = "ingredients_n")]
    public int IngredientsCount { get; set; }

    [DeserializeAs(Name = "editors_tags")] public IList<string> EditorsTags { get; set; }

    [DeserializeAs(Name = "ingredients_from_palm_oil_n")]
    public int IngredientsFromPalmOilCount { get; set; }

    [DeserializeAs(Name = "informers_tags")]
    public IList<string> InformersTags { get; set; }

    [DeserializeAs(Name = "ingredients_text")]
    public string IngredientsText { get; set; }

    [DeserializeAs(Name = "countries_hierarchy")]
    public IList<string> CountriesHierarchy { get; set; }

    [DeserializeAs(Name = "ingredients_ids_debug")]
    public IList<string> IngredientsIdsDebug { get; set; }

    [DeserializeAs(Name = "additives_n")] public int AdditivesCount { get; set; }

    [DeserializeAs(Name = "additives_prev_n")]
    public int AdditivesPreviousCount { get; set; }

    [DeserializeAs(Name = "nutrient_levels")]
    public object NutrientLevels { get; set; }

    [DeserializeAs(Name = "last_edit_dates_tags")]
    public IList<string> LastEditDatesTags { get; set; }

    [DeserializeAs(Name = "code")] public string Barcode { get; set; }

    [DeserializeAs(Name = "additives_old_tags")]
    public IList<string> AdditivesOldTags { get; set; }

    [DeserializeAs(Name = "allergens_hierarchy")]
    public IList<string> AllergensHierarchy { get; set; }

    [DeserializeAs(Name = "id")] public string Id { get; set; }

    [DeserializeAs(Name = "lc")] public string Lc { get; set; }

    [DeserializeAs(Name = "ingredients_n_tags")]
    public IList<string> IngredientsCountTags { get; set; }

    [DeserializeAs(Name = "last_modified_by")]
    public string LastModifiedBy { get; set; }

    [DeserializeAs(Name = "correctors_tags")]
    public IList<string> CorrectorsTags { get; set; }

    [DeserializeAs(Name = "additives_prev")]
    public string PreviousAdditives { get; set; }

    [DeserializeAs(Name = "additives")] public string Additives { get; set; }

    [DeserializeAs(Name = "interface_version_created")]
    public string InterfaceVersionCreated { get; set; }

    [DeserializeAs(Name = "languages_hierarchy")]
    public IList<string> LanguagesHierarcy { get; set; }

    [DeserializeAs(Name = "nutrition_score_debug")]
    public string NutritionScoreDebug { get; set; }

    [DeserializeAs(Name = "rev")] public int Rev { get; set; }

    [DeserializeAs(Name = "ingredients_from_palm_oil_tags")]
    public IList<string> IngredientsFromPalmOilTags { get; set; }

    [DeserializeAs(Name = "languages_codes")]
    public object LanguageCodes { get; set; }

    [DeserializeAs(Name = "ingredients_that_may_be_from_palm_oil_n")]
    public int IngredientsThatMayBeFromPalmOilCount { get; set; }

    [DeserializeAs(Name = "product_name_en")]
    public string ProductNameEnglish { get; set; }

    [DeserializeAs(Name = "sortkey")] public int SortKey { get; set; }

    [DeserializeAs(Name = "ingredients_text_with_allergens")]
    public string IngredientsTextWithAllergens { get; set; }

    [DeserializeAs(Name = "allergens_tags")]
    public IList<string> AllergenTags { get; set; }

    [DeserializeAs(Name = "serving_size")] public string ServingSize { get; set; }
    [DeserializeAs(Name = "languages")] public object Languages { get; set; }

    [DeserializeAs(Name = "states_hierarchy")]
    public IList<string> StateHierarchy { get; set; }

    [DeserializeAs(Name = "_keywords")] public IList<string> Keywords { get; set; }

    [DeserializeAs(Name = "update_key")] public string UpdateKey { get; set; }

    [DeserializeAs(Name = "additives_prev_original_tags")]
    public IList<string> AdditivesPreviousOriginalTags { get; set; }

    [DeserializeAs(Name = "complete")] public string Complete { get; set; }
    [DeserializeAs(Name = "brand_tags")] public IList<string> BrandTags { get; set; }

    [DeserializeAs(Name = "product_name")] public string ProductName { get; set; }

    [DeserializeAs(Name = "ingredients_tags")]
    public IList<string> IngredientsTags { get; set; }

    [DeserializeAs(Name = "states")] public string States { get; set; }
    [DeserializeAs(Name = "brands")] public string Brands { get; set; }

    [DeserializeAs(Name = "nutrition_grades_tags")]
    public IList<string> NutritionGradesTags { get; set; }

    [DeserializeAs(Name = "states_tags")] public IList<string> StatesTags { get; set; }

    [DeserializeAs(Name = "additives_tags")]
    public IList<string> AdditivesTags { get; set; }

    [DeserializeAs(Name = "quality_tags")] public IList<string> QualityTags { get; set; }

    [DeserializeAs(Name = "nutrition_data_per")]
    public string NutritionDataPer { get; set; }

    [DeserializeAs(Name = "countries_tags")]
    public IList<string> CountriesTags { get; set; }

    [DeserializeAs(Name = "unknown_nutrients_tags")]
    public IList<string> UnknownNutrientsTags { get; set; }

    [DeserializeAs(Name = "additives_original_tags")]
    public IList<string> AdditivesOriginalTags { get; set; }

    [DeserializeAs(Name = "languages_tags")]
    public IList<string> LanguagesTags { get; set; }

    [DeserializeAs(Name = "ingredients_text_with_allergens_en")]
    public string IngredientsTextWithAllergensEnglish { get; set; }

    [DeserializeAs(Name = "entry_dates_tags")]
    public IList<string> EntryDatesTags { get; set; }

    [DeserializeAs(Name = "allergens")] public string Allergens { get; set; }
    [DeserializeAs(Name = "codes_tags")] public IList<string> CodesTags { get; set; }

    [DeserializeAs(Name = "last_modified_t")]
    public DateTime? LastModified { get; set; }

    [DeserializeAs(Name = "ingredients")] public IList<object> Ingredients { get; set; }

    [DeserializeAs(Name = "checkers_tags")]
    public IList<string> CheckersTags { get; set; }

    [DeserializeAs(Name = "ingredients_debug")]
    public IList<string> IngredientsDebug { get; set; }

    [DeserializeAs(Name = "additives_prev_tags")]
    public IList<string> AdditivesPreviousTags { get; set; }

    [DeserializeAs(Name = "lang")] public string Lang { get; set; }
    [DeserializeAs(Name = "creator")] public string Creator { get; set; }
    [DeserializeAs(Name = "nutriments")] public object Nutriments { get; set; }
    [DeserializeAs(Name = "created_t")] public DateTime Created { get; set; }

    [DeserializeAs(Name = "serving_quantity")]
    public int ServingQuantity { get; set; }

    [DeserializeAs(Name = "ingredients_from_or_that_may_be_from_palm_oil_n")]
    public int IngredientsFromOrThatMayBeFromPalmOilCount { get; set; }

    [DeserializeAs(Name = "sources")] public object Sources { get; set; }

    [DeserializeAs(Name = "nutrient_levels_tags")]
    public IList<string> NutrientsLevelsTags { get; set; }

    [DeserializeAs(Name = "additives_old_n")]
    public int AdditivesOldCount { get; set; }

    [DeserializeAs(Name = "misc_tags")] public IList<string> MiscTags { get; set; }
    [DeserializeAs(Name = "_id")] public string IdBarcode { get; set; }
    [DeserializeAs(Name = "last_editor")] public string LastEditor { get; set; }
  }
}
