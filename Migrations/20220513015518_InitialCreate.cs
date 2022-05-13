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
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Favourites",
                columns: table => new
                {
                    FavouriteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FavouriteAuthor = table.Column<string>(nullable: false),
                    CarId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favourites", x => x.FavouriteId);
                    table.ForeignKey(
                        name: "FK_Favourites_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "CarId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Publications",
                columns: table => new
                {
                    PublishId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublishAuthor = table.Column<string>(nullable: false),
                    CarId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publications", x => x.PublishId);
                    table.ForeignKey(
                        name: "FK_Publications_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "CarId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    ReservationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservationAuthor = table.Column<string>(nullable: false),
                    ReservationDate = table.Column<string>(nullable: false),
                    CarId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.ReservationId);
                    table.ForeignKey(
                        name: "FK_Reservations_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "CarId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_UserId",
                table: "Cars",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Favourites_CarId",
                table: "Favourites",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Publications_CarId",
                table: "Publications",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_CarId",
                table: "Reservations",
                column: "CarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Favourites");

            migrationBuilder.DropTable(
                name: "Publications");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
