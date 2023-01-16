using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CandyShop.Migrations
{
    public partial class AddModelValidation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlavorTreats_Flavor_FlavorId",
                table: "FlavorTreats");

            migrationBuilder.DropForeignKey(
                name: "FK_FlavorTreats_Treat_TreatId",
                table: "FlavorTreats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Treat",
                table: "Treat");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Flavor",
                table: "Flavor");

            migrationBuilder.RenameTable(
                name: "Treat",
                newName: "Treats");

            migrationBuilder.RenameTable(
                name: "Flavor",
                newName: "Flavors");

            migrationBuilder.UpdateData(
                table: "Treats",
                keyColumn: "Name",
                keyValue: null,
                column: "Name",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Treats",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Flavors",
                keyColumn: "Name",
                keyValue: null,
                column: "Name",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Flavors",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Treats",
                table: "Treats",
                column: "TreatId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Flavors",
                table: "Flavors",
                column: "FlavorId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlavorTreats_Flavors_FlavorId",
                table: "FlavorTreats",
                column: "FlavorId",
                principalTable: "Flavors",
                principalColumn: "FlavorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlavorTreats_Treats_TreatId",
                table: "FlavorTreats",
                column: "TreatId",
                principalTable: "Treats",
                principalColumn: "TreatId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlavorTreats_Flavors_FlavorId",
                table: "FlavorTreats");

            migrationBuilder.DropForeignKey(
                name: "FK_FlavorTreats_Treats_TreatId",
                table: "FlavorTreats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Treats",
                table: "Treats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Flavors",
                table: "Flavors");

            migrationBuilder.RenameTable(
                name: "Treats",
                newName: "Treat");

            migrationBuilder.RenameTable(
                name: "Flavors",
                newName: "Flavor");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Treat",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Flavor",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Treat",
                table: "Treat",
                column: "TreatId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Flavor",
                table: "Flavor",
                column: "FlavorId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlavorTreats_Flavor_FlavorId",
                table: "FlavorTreats",
                column: "FlavorId",
                principalTable: "Flavor",
                principalColumn: "FlavorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlavorTreats_Treat_TreatId",
                table: "FlavorTreats",
                column: "TreatId",
                principalTable: "Treat",
                principalColumn: "TreatId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
