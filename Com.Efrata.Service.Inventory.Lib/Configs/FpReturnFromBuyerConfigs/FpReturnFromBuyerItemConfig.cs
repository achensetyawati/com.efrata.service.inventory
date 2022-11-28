using Com.Efrata.Service.Inventory.Lib.Models.FpReturnFromBuyers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Efrata.Service.Inventory.Lib.Configs.FpReturnFromBuyerConfigs
{
    public class FpReturnFromBuyerItemConfig : IEntityTypeConfiguration<FpReturnFromBuyerItemModel>
    {
        public void Configure(EntityTypeBuilder<FpReturnFromBuyerItemModel> builder)
        {
        }
    }
}
