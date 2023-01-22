using Bean.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bean.Services.Inventory
{
    public interface IInventoryService
    {
        public List<ProductInventory> GetCurrentInventory();
        public ServiceResponse<ProductInventory> UpdateUnitsAvailable(int id, int adjusment);
        public ProductInventory GetByProductId(int productId);
        
        public List<ProductInventorySnapshot> GetSnapshotHistory();
    }
}
