using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DataBase.Migrations
{
    public partial class ChangeDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientFirstName",
                table: "BookedTickets");

            migrationBuilder.DropColumn(
                name: "ClientLastName",
                table: "BookedTickets");

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "BookedTickets",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    Mail = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookedTickets_ClientId",
                table: "BookedTickets",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookedTickets_Clients_ClientId",
                table: "BookedTickets",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookedTickets_Clients_ClientId",
                table: "BookedTickets");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_BookedTickets_ClientId",
                table: "BookedTickets");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "BookedTickets");

            migrationBuilder.AddColumn<string>(
                name: "ClientFirstName",
                table: "BookedTickets",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ClientLastName",
                table: "BookedTickets",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
