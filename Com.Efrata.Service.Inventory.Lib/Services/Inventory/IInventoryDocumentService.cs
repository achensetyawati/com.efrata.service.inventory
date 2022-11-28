using Com.Efrata.Service.Inventory.Lib.Helpers;
using Com.Efrata.Service.Inventory.Lib.Interfaces;
using Com.Efrata.Service.Inventory.Lib.Models.InventoryModel;
using Com.Efrata.Service.Inventory.Lib.ViewModels.InventoryViewModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Com.Efrata.Service.Inventory.Lib.Services.Inventory
{
    public interface IInventoryDocumentService : IMap<InventoryDocument, InventoryDocumentViewModel>
    {
        ReadResponse<InventoryDocument> Read(int page, int size, string order, string keyword, string filter);
        InventoryDocument ReadModelById(int id);
        Task<int> Create(InventoryDocument model);
        Task<int> CreateMulti(List<InventoryDocument> models);
    }
}
