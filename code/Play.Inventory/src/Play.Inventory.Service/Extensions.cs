using Play.Inventory.Service.Entities;
using Play.Inventory.Service.Models;

namespace Play.Inventory.Service
{
    public static class Extensions
    {
        public static InventoryItemDto AsDto(this InventoryItem item)
        {
            return new InventoryItemDto(item.CatalogItemId, item.Quantity, item.AcquiredDate);
        }
    }
}