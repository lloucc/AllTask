using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AllTask.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class version4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Routines_Categories_CategoryId",
                table: "Routines");

            migrationBuilder.AddForeignKey(
                name: "FK_Routines_Categories_CategoryId",
                table: "Routines",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Routines_Categories_CategoryId",
                table: "Routines");

            migrationBuilder.AddForeignKey(
                name: "FK_Routines_Categories_CategoryId",
                table: "Routines",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
