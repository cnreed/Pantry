using System.Collections.Generic;
using Pantry.Enums;

namespace Pantry.Extensions
{
  public static class EnumFoodTypeExtensions
  {
    public static EnumFoodType GetEnumFoodType(this string foodType) {

      switch(foodType) {
        case "Fruit":
          return EnumFoodType.Fruit;
        case "Vegetable":
          return EnumFoodType.Vegetable;
        case "Canned":
          return EnumFoodType.Canned;
        case "Juice":
          return EnumFoodType.Juice;
        case "Soda":
          return EnumFoodType.Soda;
        case "Water":
          return EnumFoodType.Water;
        case "Candy":
          return EnumFoodType.Candy;
        case "Pasta":
          return EnumFoodType.Pasta;
        case "Bread":
          return EnumFoodType.Bread;
        case "Cereal":
          return EnumFoodType.Cereal;
        case "Condiment":
          return EnumFoodType.Condiment;
        case "Spread":
          return EnumFoodType.Spread;
        case "Cookie":
          return EnumFoodType.Cookie;
        case "Cracker":
          return EnumFoodType.Cracker;
        case "Chips":
          return EnumFoodType.Chips;
        case "Frozen":
          return EnumFoodType.Frozen;
        default:
          return EnumFoodType.DryGood;
        
      }
    }
  }
}