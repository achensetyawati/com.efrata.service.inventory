using Com.Efrata.Service.Inventory.Lib.Models.GarmentLeftoverWarehouse.BalanceStockDateMaster;
using Com.Efrata.Service.Inventory.Lib.Services;
using Com.Efrata.Service.Inventory.Lib.Services.GarmentLeftoverWarehouse.BalanceStockDateMaster;
using Com.Efrata.Service.Inventory.Lib.ViewModels.GarmentLeftoverWarehouse.BalanceStockDateMasterViewModel;
using Com.Efrata.Service.Inventory.WebApi.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Com.Efrata.Service.Inventory.WebApi.Controllers.v1.GarmentLeftoverWarehouse.BalanceStockDateMaster
{
    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/balance-stock-date-master")]
    [Authorize]
    public class GarmentBalanceStockDateMasterController : BaseController<GarmentBalanceStockDateMaster, GarmentBalanceStockDateMasterViewModel, IGarmentBalanceStockDateMasterService>
    {
        public GarmentBalanceStockDateMasterController(IIdentityService identityService, IValidateService validateService, IGarmentBalanceStockDateMasterService service) : base(identityService, validateService, service, "1.0.0")
        {
        }
    }
}
