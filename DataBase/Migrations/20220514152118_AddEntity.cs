using Microsoft.EntityFrameworkCore.Migrations;

namespace DataBase.Migrations
{
    public partial class AddEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Places_FromPlaceId",
                table: "Flights");

            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Places_ToPlaceId",
                table: "Flights");

            migrationBuilder.RenameColumn(
                name: "PlaceId",
                table: "Places",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ToPlaceId",
                table: "Flights",
                newName: "ToId");

            migrationBuilder.RenameColumn(
                name: "FromPlaceId",
                table: "Flights",
                newName: "FromId");

            migrationBuilder.RenameColumn(
                name: "FlightId",
                table: "Flights",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Flights_ToPlaceId",
                table: "Flights",
                newName: "IX_Flights_ToId");

            migrationBuilder.RenameIndex(
                name: "IX_Flights_FromPlaceId",
                table: "Flights",
                newName: "IX_Flights_FromId");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Clients",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "BookedTicketId",
                table: "BookedTickets",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Places_FromId",
                table: "Flights",
                column: "FromId",
                principalTable: "Places",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Places_ToId",
                table: "Flights",
                column: "ToId",
                principalTable: "Places",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Places_FromId",
                table: "Flights");

            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Places_ToId",
                table: "Flights");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Places",
                newName: "PlaceId");

            migrationBuilder.RenameColumn(
                name: "ToId",
                table: "Flights",
                newName: "ToPlaceId");

            migrationBuilder.RenameColumn(
                name: "FromId",
                table: "Flights",
                newName: "FromPlaceId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Flights",
                newName: "FlightId");

            migrationBuilder.RenameIndex(
                name: "IX_Flights_ToId",
                table: "Flights",
                newName: "IX_Flights_ToPlaceId");

            migrationBuilder.RenameIndex(
                name: "IX_Flights_FromId",
                table: "Flights",
                newName: "IX_Flights_FromPlaceId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Clients",
                newName: "ClientId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "BookedTickets",
                newName: "BookedTicketId");

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Places_FromPlaceId",
                table: "Flights",
                column: "FromPlaceId",
                principalTable: "Places",
                principalColumn: "PlaceId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Places_ToPlaceId",
                table: "Flights",
                column: "ToPlaceId",
                principalTable: "Places",
                principalColumn: "PlaceId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
