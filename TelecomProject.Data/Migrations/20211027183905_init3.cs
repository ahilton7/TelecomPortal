using Microsoft.EntityFrameworkCore.Migrations;

namespace TelecomProject.Data.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Devices_Phone_number",
                table: "Devices");

            migrationBuilder.AlterColumn<int>(
                name: "Phone_number",
                table: "Devices",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_Phone_number",
                table: "Devices",
                column: "Phone_number",
                unique: true,
                filter: "[Phone_number] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Devices_Phone_number",
                table: "Devices");

            migrationBuilder.AlterColumn<int>(
                name: "Phone_number",
                table: "Devices",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Devices_Phone_number",
                table: "Devices",
                column: "Phone_number",
                unique: true);
        }
    }
}
