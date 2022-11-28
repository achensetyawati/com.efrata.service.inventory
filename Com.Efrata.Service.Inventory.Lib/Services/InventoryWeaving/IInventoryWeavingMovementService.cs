using Com.Efrata.Service.Inventory.Lib.Helpers;
using Com.Efrata.Service.Inventory.Lib.Interfaces;
using Com.Efrata.Service.Inventory.Lib.Models.InventoryWeavingModel;
using Com.Efrata.Service.Inventory.Lib.ViewModels.InventoryWeavingViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Com.Efrata.Service.Inventory.Lib.Services.InventoryWeaving
{
    public interface IInventoryWeavingMovementService
    {
        Task<int> Create(InventoryWeavingMovement model , string username);
        // ListResult<InventoryWeavingMovementDetailViewModel> ReadReport(string grade, DateTimeOffset? dateFrom, DateTimeOffset? dateTo, int page, int size, string order, int offset);
        Tuple<List<InventoryWeavingInOutViewModel>, int> ReadReportGrade(string grade, DateTime? dateTo, int page, int size, string Order, int offset);
       // List<InventoryWeavingItemDetailViewModel> GetGrade(string grade, DateTimeOffset? dateTo, int offset);
        MemoryStream GenerateExcel(string grade, DateTime? dateTo, int offset);
        Task<int> UpdateAsync(InventoryWeavingMovement model);
        Tuple<List<InventoryWeavingInOutViewModel>, int> ReadReportRecap(string bonType, DateTime? dateFrom, DateTime? dateTo, int page, int size, string Order, int offset);
        MemoryStream GenerateExcelRecap(string bonType, DateTime? dateFrom, DateTime? dateTo, int offset);
    }
}

