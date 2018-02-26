using Pantry.Enums;
using SQLite;

namespace Pantry.Models
{
    [Table("Item")]
    public class Item
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [NotNull]
        public string Name { get; set; }
        public EnumFoodType FoodType { get; set; }
        public EnumPlaceStored PlaceStored { get; set; }
        public int Quantity { get; set; }
        public string Barcode { get; set; }
        public string StorageLocation { get; set; }
        public bool IsFrozen { get; set; }
    }
}