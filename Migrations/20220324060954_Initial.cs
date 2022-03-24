using Microsoft.EntityFrameworkCore.Migrations;

namespace Group3_14_Project2.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    TourId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<string>(nullable: false),
                    Time = table.Column<string>(nullable: false),
                    GroupName = table.Column<string>(nullable: false),
                    GroupSize = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    PhoneNum = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.TourId);
                });

            migrationBuilder.CreateTable(
                name: "Times",
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
                    Time13 = table.Column<string>(nullable: true),
                    Available1 = table.Column<bool>(nullable: false),
                    Available2 = table.Column<bool>(nullable: false),
                    Available3 = table.Column<bool>(nullable: false),
                    Available4 = table.Column<bool>(nullable: false),
                    Available5 = table.Column<bool>(nullable: false),
                    Available6 = table.Column<bool>(nullable: false),
                    Available7 = table.Column<bool>(nullable: false),
                    Available8 = table.Column<bool>(nullable: false),
                    Available9 = table.Column<bool>(nullable: false),
                    Available10 = table.Column<bool>(nullable: false),
                    Available11 = table.Column<bool>(nullable: false),
                    Available12 = table.Column<bool>(nullable: false),
                    Available13 = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Times", x => x.Date);
                });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "Date", "Available1", "Available10", "Available11", "Available12", "Available13", "Available2", "Available3", "Available4", "Available5", "Available6", "Available7", "Available8", "Available9", "DayName", "Time1", "Time10", "Time11", "Time12", "Time13", "Time2", "Time3", "Time4", "Time5", "Time6", "Time7", "Time8", "Time9" },
                values: new object[] { "3/23/2022", true, true, true, true, true, true, true, true, true, true, true, true, true, "Wednesday", "8 AM", "5 PM", "6 PM", "7 PM", "8 PM", "9 AM", "10 AM", "11 AM", "12 PM", "1 PM", "2 PM", "3 PM", "4 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "Date", "Available1", "Available10", "Available11", "Available12", "Available13", "Available2", "Available3", "Available4", "Available5", "Available6", "Available7", "Available8", "Available9", "DayName", "Time1", "Time10", "Time11", "Time12", "Time13", "Time2", "Time3", "Time4", "Time5", "Time6", "Time7", "Time8", "Time9" },
                values: new object[] { "3/24/2022", true, true, true, true, true, true, true, true, true, true, true, true, true, "Thursday", "8 AM", "5 PM", "6 PM", "7 PM", "8 PM", "9 AM", "10 AM", "11 AM", "12 PM", "1 PM", "2 PM", "3 PM", "4 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "Date", "Available1", "Available10", "Available11", "Available12", "Available13", "Available2", "Available3", "Available4", "Available5", "Available6", "Available7", "Available8", "Available9", "DayName", "Time1", "Time10", "Time11", "Time12", "Time13", "Time2", "Time3", "Time4", "Time5", "Time6", "Time7", "Time8", "Time9" },
                values: new object[] { "3/25/2022", true, true, true, true, true, true, true, true, true, true, true, true, true, "Friday", "8 AM", "5 PM", "6 PM", "7 PM", "8 PM", "9 AM", "10 AM", "11 AM", "12 PM", "1 PM", "2 PM", "3 PM", "4 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "Date", "Available1", "Available10", "Available11", "Available12", "Available13", "Available2", "Available3", "Available4", "Available5", "Available6", "Available7", "Available8", "Available9", "DayName", "Time1", "Time10", "Time11", "Time12", "Time13", "Time2", "Time3", "Time4", "Time5", "Time6", "Time7", "Time8", "Time9" },
                values: new object[] { "3/26/2022", true, true, true, true, true, true, true, true, true, true, true, true, true, "Saturday", "8 AM", "5 PM", "6 PM", "7 PM", "8 PM", "9 AM", "10 AM", "11 AM", "12 PM", "1 PM", "2 PM", "3 PM", "4 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "Date", "Available1", "Available10", "Available11", "Available12", "Available13", "Available2", "Available3", "Available4", "Available5", "Available6", "Available7", "Available8", "Available9", "DayName", "Time1", "Time10", "Time11", "Time12", "Time13", "Time2", "Time3", "Time4", "Time5", "Time6", "Time7", "Time8", "Time9" },
                values: new object[] { "3/27/2022", true, true, true, true, true, true, true, true, true, true, true, true, true, "Sunday", "8 AM", "5 PM", "6 PM", "7 PM", "8 PM", "9 AM", "10 AM", "11 AM", "12 PM", "1 PM", "2 PM", "3 PM", "4 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "Date", "Available1", "Available10", "Available11", "Available12", "Available13", "Available2", "Available3", "Available4", "Available5", "Available6", "Available7", "Available8", "Available9", "DayName", "Time1", "Time10", "Time11", "Time12", "Time13", "Time2", "Time3", "Time4", "Time5", "Time6", "Time7", "Time8", "Time9" },
                values: new object[] { "3/28/2022", true, true, true, true, true, true, true, true, true, true, true, true, true, "Monday", "8 AM", "5 PM", "6 PM", "7 PM", "8 PM", "9 AM", "10 AM", "11 AM", "12 PM", "1 PM", "2 PM", "3 PM", "4 PM" });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "Date", "Available1", "Available10", "Available11", "Available12", "Available13", "Available2", "Available3", "Available4", "Available5", "Available6", "Available7", "Available8", "Available9", "DayName", "Time1", "Time10", "Time11", "Time12", "Time13", "Time2", "Time3", "Time4", "Time5", "Time6", "Time7", "Time8", "Time9" },
                values: new object[] { "3/29/2022", true, true, true, true, true, true, true, true, true, true, true, true, true, "Tuesday", "8 AM", "5 PM", "6 PM", "7 PM", "8 PM", "9 AM", "10 AM", "11 AM", "12 PM", "1 PM", "2 PM", "3 PM", "4 PM" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Times");
        }
    }
}
