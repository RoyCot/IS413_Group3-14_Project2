using Microsoft.EntityFrameworkCore.Migrations;

namespace Group3_14_Project2.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TourTimes",
                columns: table => new
                {
                    Date = table.Column<string>(nullable: false),
                    DayName = table.Column<string>(nullable: true),
                    Time1 = table.Column<string>(nullable: true),
                    Time2 = table.Column<string>(nullable: true),
                    Time3 = table.Column<string>(nullable: true),
                    Time4 = table.Column<string>(nullable: true),
                    Time5 = table.Column<string>(nullable: true),
                    Time6 = table.Column<string>(nullable: true),
                    Time7 = table.Column<string>(nullable: true),
                    Time8 = table.Column<string>(nullable: true),
                    Time9 = table.Column<string>(nullable: true),
                    Time10 = table.Column<string>(nullable: true),
                    Time11 = table.Column<string>(nullable: true),
                    Time12 = table.Column<string>(nullable: true),
                    Time13 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourTimes", x => x.Date);
                });

            migrationBuilder.InsertData(
                table: "TourTimes",
                columns: new[] { "Date", "DayName", "Time1", "Time10", "Time11", "Time12", "Time13", "Time2", "Time3", "Time4", "Time5", "Time6", "Time7", "Time8", "Time9" },
                values: new object[] { "3/23/2022", "Wednesday", "8 AM", "5 PM", "6 PM", "7 PM", "8 PM", "9 AM", "10 AM", "11 AM", "12 AM", "1 PM", "2 PM", "3 PM", "4 PM" });

            migrationBuilder.InsertData(
                table: "TourTimes",
                columns: new[] { "Date", "DayName", "Time1", "Time10", "Time11", "Time12", "Time13", "Time2", "Time3", "Time4", "Time5", "Time6", "Time7", "Time8", "Time9" },
                values: new object[] { "3/24/2022", "Thursday", "8 AM", "5 PM", "6 PM", "7 PM", "8 PM", "9 AM", "10 AM", "11 AM", "12 AM", "1 PM", "2 PM", "3 PM", "4 PM" });

            migrationBuilder.InsertData(
                table: "TourTimes",
                columns: new[] { "Date", "DayName", "Time1", "Time10", "Time11", "Time12", "Time13", "Time2", "Time3", "Time4", "Time5", "Time6", "Time7", "Time8", "Time9" },
                values: new object[] { "3/25/2022", "Friday", "8 AM", "5 PM", "6 PM", "7 PM", "8 PM", "9 AM", "10 AM", "11 AM", "12 AM", "1 PM", "2 PM", "3 PM", "4 PM" });

            migrationBuilder.InsertData(
                table: "TourTimes",
                columns: new[] { "Date", "DayName", "Time1", "Time10", "Time11", "Time12", "Time13", "Time2", "Time3", "Time4", "Time5", "Time6", "Time7", "Time8", "Time9" },
                values: new object[] { "3/26/2022", "Saturday", "8 AM", "5 PM", "6 PM", "7 PM", "8 PM", "9 AM", "10 AM", "11 AM", "12 AM", "1 PM", "2 PM", "3 PM", "4 PM" });

            migrationBuilder.InsertData(
                table: "TourTimes",
                columns: new[] { "Date", "DayName", "Time1", "Time10", "Time11", "Time12", "Time13", "Time2", "Time3", "Time4", "Time5", "Time6", "Time7", "Time8", "Time9" },
                values: new object[] { "3/27/2022", "Sunday", "8 AM", "5 PM", "6 PM", "7 PM", "8 PM", "9 AM", "10 AM", "11 AM", "12 AM", "1 PM", "2 PM", "3 PM", "4 PM" });

            migrationBuilder.InsertData(
                table: "TourTimes",
                columns: new[] { "Date", "DayName", "Time1", "Time10", "Time11", "Time12", "Time13", "Time2", "Time3", "Time4", "Time5", "Time6", "Time7", "Time8", "Time9" },
                values: new object[] { "3/28/2022", "Monday", "8 AM", "5 PM", "6 PM", "7 PM", "8 PM", "9 AM", "10 AM", "11 AM", "12 AM", "1 PM", "2 PM", "3 PM", "4 PM" });

            migrationBuilder.InsertData(
                table: "TourTimes",
                columns: new[] { "Date", "DayName", "Time1", "Time10", "Time11", "Time12", "Time13", "Time2", "Time3", "Time4", "Time5", "Time6", "Time7", "Time8", "Time9" },
                values: new object[] { "3/29/2022", "Tuesday", "8 AM", "5 PM", "6 PM", "7 PM", "8 PM", "9 AM", "10 AM", "11 AM", "12 AM", "1 PM", "2 PM", "3 PM", "4 PM" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TourTimes");
        }
    }
}
