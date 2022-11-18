using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking.DAL.Migrations
{
    public partial class intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReseverationDetails_Reservations_ReservationsId",
                table: "ReseverationDetails");

            migrationBuilder.AlterColumn<int>(
                name: "ReservationsId",
                table: "ReseverationDetails",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ReseverationDetails_Reservations_ReservationsId",
                table: "ReseverationDetails",
                column: "ReservationsId",
                principalTable: "Reservations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReseverationDetails_Reservations_ReservationsId",
                table: "ReseverationDetails");

            migrationBuilder.AlterColumn<int>(
                name: "ReservationsId",
                table: "ReseverationDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ReseverationDetails_Reservations_ReservationsId",
                table: "ReseverationDetails",
                column: "ReservationsId",
                principalTable: "Reservations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
