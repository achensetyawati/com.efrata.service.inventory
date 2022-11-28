using Com.Efrata.Service.Inventory.Lib.Models.GarmentLeftoverWarehouse.ExpenditureFabric;
using Com.Efrata.Service.Inventory.Lib.ViewModels;
using Com.Efrata.Service.Inventory.Lib.ViewModels.GarmentLeftoverWarehouse.ExpenditureFabric;
using System.Collections.Generic;

namespace Com.Efrata.Service.Inventory.Lib.Services.GarmentLeftoverWarehouse.ExpenditureFabric
{
    public interface IGarmentLeftoverWarehouseExpenditureFabricService : IBaseService<GarmentLeftoverWarehouseExpenditureFabric, GarmentLeftoverWarehouseExpenditureFabricViewModel>
    {
        double CheckStockQuantity(int Id, int StockId);
        List<GarmentProductViewModel> getProductForPDF(GarmentLeftoverWarehouseExpenditureFabric model);
    }
}
