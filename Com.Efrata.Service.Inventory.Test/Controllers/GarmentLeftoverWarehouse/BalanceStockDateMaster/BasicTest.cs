using Com.Efrata.Service.Inventory.Lib.Models.GarmentLeftoverWarehouse.BalanceStockDateMaster;
using Com.Efrata.Service.Inventory.Lib.Services.GarmentLeftoverWarehouse.BalanceStockDateMaster;
using Com.Efrata.Service.Inventory.Lib.ViewModels.GarmentLeftoverWarehouse.BalanceStockDateMasterViewModel;
using Com.Efrata.Service.Inventory.Test.Helpers;
using Com.Efrata.Service.Inventory.WebApi.Controllers.v1.GarmentLeftoverWarehouse.BalanceStockDateMaster;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Efrata.Service.Inventory.Test.Controllers.GarmentLeftoverWarehouse.BalanceStockDateMaster
{
    public class BasicTest : BaseControllerTest<GarmentBalanceStockDateMasterController, GarmentBalanceStockDateMaster, GarmentBalanceStockDateMasterViewModel, IGarmentBalanceStockDateMasterService>
    {
    }
}
