using Microsoft.EntityFrameworkCore.Migrations;

namespace DreamCar.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserUsername = table.Column<string>(type: "varchar(1000)", nullable: false),
                    UserPassword = table.Column<string>(type: "varchar(1000)", nullable: false),
                    UserFirstName = table.Column<string>(type: "varchar(1000)", nullable: false),
                    UserLastName = table.Column<string>(type: "varchar(1000)", nullable: false),
                    UserCountry = table.Column<string>(type: "varchar(1000)", nullable: false),
                    UserCity = table.Column<string>(type: "varchar(1000)", nullable: false),
                    UserAddress = table.Column<string>(type: "varchar(1000)", nullable: false),
                    UserPhone = table.Column<string>(type: "varchar(1000)", nullable: false),
                    UserEmail = table.Column<string>(type: "varchar(1000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    CarId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarCountry = table.Column<string>(type: "varchar(1000)", nullable: false),
                    CarCity = table.Column<string>(type: "varchar(1000)", nullable: false),
                    CarName = table.Column<string>(type: "varchar(1000)", nullable: false),
                    CarBrand = table.Column<string>(type: "varchar(1000)", nullable: false),
                    CarModel = table.Column<string>(type: "varchar(1000)", nullable: false),
                    CarCapacity = table.Column<int>(nullable: false),
                    CarProdYear = table.Column<int>(nullable: false),
                    CarColor = table.Column<string>(type: "varchar(1000)", nullable: false),
                    CarFuel = table.Column<string>(type: "varchar(1000)", nullable: false),
                    CarGearbox = table.Column<string>(type: "varchar(1000)", nullable: false),
                    CarImageUrl = table.Column<string>(type: "varchar(1000)", nullable: false),
                    CarPrice = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    CarTags = table.Column<string>(type: "varchar(1000)", nullable: false),
                    CarReservationDateStart = table.Column<string>(type: "varchar(1000)", nullable: false),
                    CarReservationDateEnd = table.Column<string>(type: "varchar(1000)", nullable: false),
                    CarIsSold = table.Column<bool>(nullable: false),
                    CarIsReserved = table.Column<bool>(nullable: false),
                    CarAuthor = table.Column<string>(type: "varchar(1000)", nullable: false),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.CarId);
                    table.ForeignKey(
                        name: "FK_Cars_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Favourite",
                columns: table => new
                {
                    FavouriteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FavouriteAuthor = table.Column<string>(nullable: false),
                    CarId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favourite", x => x.FavouriteId);
                    table.ForeignKey(
                        name: "FK_Favourite_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "CarId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Publish",
                columns: table => new
                {
                    PublishId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublishAuthor = table.Column<string>(nullable: false),
                    CarId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publish", x => x.PublishId);
                    table.ForeignKey(
                        name: "FK_Publish_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "CarId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reservation",
                columns: table => new
                {
                    ReservationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservationAuthor = table.Column<string>(nullable: false),
                    CarId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservation", x => x.ReservationId);
                    table.ForeignKey(
                        name: "FK_Reservation_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "CarId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_UserId",
                table: "Cars",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Favourite_CarId",
                table: "Favourite",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Publish_CarId",
                table: "Publish",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_CarId",
                table: "Reservation",
                column: "CarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Favourite");

            migrationBuilder.DropTable(
                name: "Publish");

            migrationBuilder.DropTable(
                name: "Reservation");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
