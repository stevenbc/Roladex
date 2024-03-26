using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Roladex.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Address11 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Address12 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Address1City = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Address1State = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Address1Zip = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Address21 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Address22 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Address2City = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Address2State = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Address2Zip = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Email1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Email2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Telephone1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Telephone2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
