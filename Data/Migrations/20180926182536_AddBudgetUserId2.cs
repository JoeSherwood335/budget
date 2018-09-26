using Microsoft.EntityFrameworkCore.Migrations;

namespace budget.Data.Migrations
{
    public partial class AddBudgetUserId2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BudgetUserId",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BudgetUserId",
                table: "AspNetUsers");
        }
    }
}
