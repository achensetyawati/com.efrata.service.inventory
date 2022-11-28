using Com.Efrata.Service.Inventory.Lib.Models.GarmentLeftoverWarehouse.ExpenditureAccessories;
using Com.Efrata.Service.Inventory.Lib.Models.GarmentLeftoverWarehouse.ReceiptAccessories;
using Com.Efrata.Service.Inventory.Lib.ViewModels.GarmentLeftoverWarehouse.ExpenditureAccessories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Efrata.Service.Inventory.Lib.Services.GarmentLeftoverWarehouse.ExpenditureAccessories
{
    public interface IGarmentLeftoverWarehouseExpenditureAccessoriesService : IBaseService<GarmentLeftoverWarehouseExpenditureAccessories, GarmentLeftoverWarehouseExpenditureAccessoriesViewModel>
    {
        double CheckStockQuantity(int Id, int StockId);
        List<GarmentLeftoverWarehouseReceiptAccessoryItem> getProductForPDF(GarmentLeftoverWarehouseExpenditureAccessories model);
    }
}
