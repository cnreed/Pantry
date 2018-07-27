using Pantry.Enums;

namespace Pantry.Extensions
{
    public static class PlaceStoredExtension
    {
        public static string CreateStorageLocationPrefix(this EnumPlaceStored stored)
        {
            switch (stored)
            {
                    case EnumPlaceStored.Cabinent:
                        return "CAB";
                    case EnumPlaceStored.Garage:
                        return "GAR";
                    case EnumPlaceStored.Pantry:
                        return "PAN";
                    case EnumPlaceStored.Refrigerator:
                        return "FRIG";
                    case EnumPlaceStored.Drawer:
                        return "DRWR";
                    case EnumPlaceStored.FruitBowl:
                        return "FBWL";
                default:
                    return "UNKWN";
            }
        }

        public static EnumPlaceStored GetPlaceStored(this string enumString) {


            switch(enumString) {
                
            }
            return EnumPlaceStored.Cabinent;
        }
    }
}