using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BetBoomMVC.Migrations
{
    /// <inheritdoc />
    public partial class addnewtable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsFinished",
                table: "Events",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsFinished",
                table: "Events");
        }
    }
}
