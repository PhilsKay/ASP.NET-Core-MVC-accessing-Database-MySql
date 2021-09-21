using Microsoft.EntityFrameworkCore.Migrations;

namespace ConnectionDatabase.Migrations
{
    public partial class DbCorrection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "Age",
                table: "Person",
                type: "tinyInt(3)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "tinyInt(1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Age",
                table: "Person",
                type: "tinyInt(1)",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyInt(3)");
        }
    }
}
