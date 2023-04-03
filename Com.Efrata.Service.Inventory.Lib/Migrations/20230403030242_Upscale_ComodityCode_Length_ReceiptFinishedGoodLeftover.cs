using Microsoft.EntityFrameworkCore.Migrations;

namespace Com.Efrata.Service.Inventory.Lib.Migrations
{
    public partial class Upscale_ComodityCode_Length_ReceiptFinishedGoodLeftover : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ComodityCode",
                table: "GarmentLeftoverWarehouseReceiptFinishedGoodItems",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ComodityCode",
                table: "GarmentLeftoverWarehouseReceiptFinishedGoodItems",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);
        }
    }
}
