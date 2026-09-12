using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace The25th_WEB.Migrations;

/// <inheritdoc />
public partial class _20260912075939_AddValidation : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AlterColumn<string>(
            name: "Name",
            table: "Categories",
            type: "nvarchar(100)",
            maxLength: 100,
            nullable: false,
            oldClrType: typeof(string),
            oldType: "nvarchar(max)");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AlterColumn<string>(
            name: "Name",
            table: "Categories",
            type: "nvarchar(max)",
            nullable: false,
            oldClrType: typeof(string),
            oldType: "nvarchar(100)",
            oldMaxLength: 100);
    }
}
