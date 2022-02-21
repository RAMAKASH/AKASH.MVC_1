using Microsoft.EntityFrameworkCore.Migrations;

namespace AKASH.MVC_1.Migrations
{
    public partial class w2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Locations_Locationid",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Locations",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Customers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Locationid",
                table: "Customers",
                newName: "LocationId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Customers",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_Locationid",
                table: "Customers",
                newName: "IX_Customers_LocationId");

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Locations_LocationId",
                table: "Customers",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Locations_LocationId",
                table: "Customers");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Locations",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Customers",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "LocationId",
                table: "Customers",
                newName: "Locationid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Customers",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_LocationId",
                table: "Customers",
                newName: "IX_Customers_Locationid");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Locations_Locationid",
                table: "Customers",
                column: "Locationid",
                principalTable: "Locations",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
