using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BetBoomMVC.Migrations
{
    /// <inheritdoc />
    public partial class newField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "SportTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "SportTypes");
        }
    }
}
