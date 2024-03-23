using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserDemo2.Migrations
{
    /// <inheritdoc />
    public partial class PasswordChange_ForPass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Users_Password",
                table: "Users",
                column: "Password");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_Password",
                table: "Users");
        }
    }
}
