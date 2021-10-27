using Microsoft.EntityFrameworkCore.Migrations;

namespace TelecomProject.Data.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Devices_Phone_number",
                table: "Devices",
                column: "Phone_number",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Devices_Phone_number",
                table: "Devices");
        }
    }
}
