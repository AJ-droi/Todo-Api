using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Todo_Api.Migrations
{
    /// <inheritdoc />
    public partial class RenameColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsCompleted",
                table: "Todo",
                newName: "isCompleted");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Todo",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Todo",
                newName: "id");

            migrationBuilder.AddColumn<string>(
                name: "title",
                table: "Todo",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "title",
                table: "Todo");

            migrationBuilder.RenameColumn(
                name: "isCompleted",
                table: "Todo",
                newName: "IsCompleted");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Todo",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Todo",
                newName: "Id");
        }
    }
}
