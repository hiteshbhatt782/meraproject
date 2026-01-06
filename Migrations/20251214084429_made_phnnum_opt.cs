using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace meraproject.Migrations
{
    /// <inheritdoc />
    public partial class made_phnnum_opt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "course",
                table: "Students",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Students",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "address",
                table: "Students",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isActive",
                table: "Students",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "address",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "isActive",
                table: "Students");

            migrationBuilder.AlterColumn<string>(
                name: "course",
                table: "Students",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }
    }
}
