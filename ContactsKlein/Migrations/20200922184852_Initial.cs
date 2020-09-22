using Microsoft.EntityFrameworkCore.Migrations;

namespace ContactsKlein.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "Address", "FirstName", "LastName", "Note", "PhoneNumber" },
                values: new object[] { 1, "111 lame st, Sylvester, IA", "Kelly", "Klein", "fake info", "555-555-5555" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "Address", "FirstName", "LastName", "Note", "PhoneNumber" },
                values: new object[] { 2, "42 bonzi lane, Okinawa, Japan", "Pat", "Morita", "more fake info", "456-123-8974" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
