using Microsoft.EntityFrameworkCore.Migrations;

namespace BookingSystem.Migrations
{
    public partial class UPDATE_BookedTicket_TABLE : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CVV",
                table: "BookedTickets",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CardNumber",
                table: "BookedTickets",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Expiry",
                table: "BookedTickets",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CVV",
                table: "BookedTickets");

            migrationBuilder.DropColumn(
                name: "CardNumber",
                table: "BookedTickets");

            migrationBuilder.DropColumn(
                name: "Expiry",
                table: "BookedTickets");
        }
    }
}
