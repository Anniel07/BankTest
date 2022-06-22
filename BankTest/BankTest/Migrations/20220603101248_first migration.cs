using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BankTest.Migrations
{
    public partial class firstmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Addresses = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateofBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonalPhoto = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Contact",
                columns: new[] { "ID", "Addresses", "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[,]
                {
                    { 1, "Some Adress 0", new DateTime(1, 1, 1, 0, 0, 0, 201, DateTimeKind.Unspecified).AddTicks(7968), "Brayan", "avatar.png", "64438592", "Lee" },
                    { 28, "Some Adress 27", new DateTime(1, 1, 1, 0, 0, 0, 823, DateTimeKind.Unspecified).AddTicks(9111), "Juliet", "avatar.png", "84674432", "Garcia" },
                    { 29, "Some Adress 28", new DateTime(1, 1, 1, 0, 0, 0, 986, DateTimeKind.Unspecified).AddTicks(6587), "Juliet", "avatar.png", "29653971", "Hernandez" },
                    { 30, "Some Adress 29", new DateTime(1, 1, 1, 0, 0, 0, 619, DateTimeKind.Unspecified).AddTicks(3055), "Carlos", "avatar.png", "68010938", "Tapanez" },
                    { 31, "Some Adress 30", new DateTime(1, 1, 1, 0, 0, 0, 371, DateTimeKind.Unspecified).AddTicks(6032), "Jhon", "avatar.png", "58549335", "Garcia" },
                    { 32, "Some Adress 31", new DateTime(1, 1, 1, 0, 0, 0, 695, DateTimeKind.Unspecified).AddTicks(3379), "Carlos", "avatar.png", "10219598", "Doe" },
                    { 33, "Some Adress 32", new DateTime(1, 1, 1, 0, 0, 0, 636, DateTimeKind.Unspecified).AddTicks(698), "Miguel", "avatar.png", "99884480", "Fernandez" },
                    { 34, "Some Adress 33", new DateTime(1, 1, 1, 0, 0, 0, 356, DateTimeKind.Unspecified).AddTicks(5161), "Brayan", "avatar.png", "17844253", "Stampton" },
                    { 35, "Some Adress 34", new DateTime(1, 1, 1, 0, 0, 0, 765, DateTimeKind.Unspecified).AddTicks(9094), "Miguel", "avatar.png", "81747270", "Lee" },
                    { 36, "Some Adress 35", new DateTime(1, 1, 1, 0, 0, 0, 948, DateTimeKind.Unspecified).AddTicks(8332), "Miguel", "avatar.png", "93047067", "Tapanez" },
                    { 37, "Some Adress 36", new DateTime(1, 1, 1, 0, 0, 0, 296, DateTimeKind.Unspecified).AddTicks(6739), "Jhon", "avatar.png", "47174406", "Lee" },
                    { 38, "Some Adress 37", new DateTime(1, 1, 1, 0, 0, 0, 289, DateTimeKind.Unspecified).AddTicks(5732), "Jhon", "avatar.png", "60131879", "Garcia" },
                    { 39, "Some Adress 38", new DateTime(1, 1, 1, 0, 0, 0, 698, DateTimeKind.Unspecified).AddTicks(6008), "Tedd", "avatar.png", "28076827", "Tapanez" },
                    { 40, "Some Adress 39", new DateTime(1, 1, 1, 0, 0, 0, 477, DateTimeKind.Unspecified).AddTicks(3647), "Carlos", "avatar.png", "41233923", "Hernandez" },
                    { 41, "Some Adress 40", new DateTime(1, 1, 1, 0, 0, 0, 953, DateTimeKind.Unspecified).AddTicks(6966), "Miguel", "avatar.png", "61198392", "Fernandez" },
                    { 42, "Some Adress 41", new DateTime(1, 1, 1, 0, 0, 0, 611, DateTimeKind.Unspecified).AddTicks(875), "Juliet", "avatar.png", "29294536", "Lee" },
                    { 43, "Some Adress 42", new DateTime(1, 1, 1, 0, 0, 0, 609, DateTimeKind.Unspecified).AddTicks(3925), "Juliet", "avatar.png", "77524176", "Tapanez" },
                    { 44, "Some Adress 43", new DateTime(1, 1, 1, 0, 0, 0, 960, DateTimeKind.Unspecified).AddTicks(3069), "Brayan", "avatar.png", "29700983", "Lee" },
                    { 45, "Some Adress 44", new DateTime(1, 1, 1, 0, 0, 0, 478, DateTimeKind.Unspecified).AddTicks(3056), "Miguel", "avatar.png", "75081944", "Fernandez" },
                    { 46, "Some Adress 45", new DateTime(1, 1, 1, 0, 0, 0, 953, DateTimeKind.Unspecified).AddTicks(2828), "Juliet", "avatar.png", "22924874", "Hernandez" },
                    { 47, "Some Adress 46", new DateTime(1, 1, 1, 0, 0, 0, 702, DateTimeKind.Unspecified).AddTicks(2881), "Brayan", "avatar.png", "41545708", "Doe" },
                    { 48, "Some Adress 47", new DateTime(1, 1, 1, 0, 0, 0, 623, DateTimeKind.Unspecified).AddTicks(582), "Jhon", "avatar.png", "54571307", "Doe" },
                    { 27, "Some Adress 26", new DateTime(1, 1, 1, 0, 0, 0, 447, DateTimeKind.Unspecified).AddTicks(447), "Carlos", "avatar.png", "59826613", "Hernandez" },
                    { 26, "Some Adress 25", new DateTime(1, 1, 1, 0, 0, 0, 726, DateTimeKind.Unspecified).AddTicks(9274), "Marcos", "avatar.png", "89033297", "Lee" },
                    { 25, "Some Adress 24", new DateTime(1, 1, 1, 0, 0, 0, 600, DateTimeKind.Unspecified).AddTicks(3090), "Carlos", "avatar.png", "78707150", "Tapanez" },
                    { 24, "Some Adress 23", new DateTime(1, 1, 1, 0, 0, 0, 711, DateTimeKind.Unspecified).AddTicks(8604), "Miguel", "avatar.png", "71106215", "Doe" },
                    { 2, "Some Adress 1", new DateTime(1, 1, 1, 0, 0, 0, 606, DateTimeKind.Unspecified).AddTicks(8433), "Tedd", "avatar.png", "17850619", "Doe" },
                    { 3, "Some Adress 2", new DateTime(1, 1, 1, 0, 0, 0, 822, DateTimeKind.Unspecified).AddTicks(6207), "Tedd", "avatar.png", "47162071", "Hernandez" },
                    { 4, "Some Adress 3", new DateTime(1, 1, 1, 0, 0, 0, 313, DateTimeKind.Unspecified).AddTicks(4644), "Miguel", "avatar.png", "77440155", "Doe" },
                    { 5, "Some Adress 4", new DateTime(1, 1, 1, 0, 0, 0, 578, DateTimeKind.Unspecified).AddTicks(9046), "Tedd", "avatar.png", "83567678", "Tapanez" },
                    { 6, "Some Adress 5", new DateTime(1, 1, 1, 0, 0, 0, 183, DateTimeKind.Unspecified).AddTicks(2314), "Miguel", "avatar.png", "77548711", "Garcia" },
                    { 7, "Some Adress 6", new DateTime(1, 1, 1, 0, 0, 0, 557, DateTimeKind.Unspecified).AddTicks(5941), "Brayan", "avatar.png", "54877433", "Fernandez" },
                    { 8, "Some Adress 7", new DateTime(1, 1, 1, 0, 0, 0, 551, DateTimeKind.Unspecified).AddTicks(6597), "Juliet", "avatar.png", "34442303", "Stampton" },
                    { 9, "Some Adress 8", new DateTime(1, 1, 1, 0, 0, 0, 669, DateTimeKind.Unspecified).AddTicks(7169), "Juliet", "avatar.png", "29160323", "Tapanez" },
                    { 10, "Some Adress 9", new DateTime(1, 1, 1, 0, 0, 0, 927, DateTimeKind.Unspecified).AddTicks(6606), "Carlos", "avatar.png", "32247470", "Doe" },
                    { 11, "Some Adress 10", new DateTime(1, 1, 1, 0, 0, 0, 601, DateTimeKind.Unspecified).AddTicks(254), "Marcos", "avatar.png", "34726564", "Stampton" },
                    { 49, "Some Adress 48", new DateTime(1, 1, 1, 0, 0, 0, 264, DateTimeKind.Unspecified).AddTicks(4256), "Tedd", "avatar.png", "37495365", "Fernandez" },
                    { 12, "Some Adress 11", new DateTime(1, 1, 1, 0, 0, 0, 567, DateTimeKind.Unspecified).AddTicks(8563), "Tedd", "avatar.png", "24351959", "Hernandez" },
                    { 14, "Some Adress 13", new DateTime(1, 1, 1, 0, 0, 0, 582, DateTimeKind.Unspecified).AddTicks(8460), "Marcos", "avatar.png", "73861815", "Doe" },
                    { 15, "Some Adress 14", new DateTime(1, 1, 1, 0, 0, 0, 395, DateTimeKind.Unspecified).AddTicks(130), "Miguel", "avatar.png", "89208886", "Fernandez" },
                    { 16, "Some Adress 15", new DateTime(1, 1, 1, 0, 0, 0, 207, DateTimeKind.Unspecified).AddTicks(4716), "Carlos", "avatar.png", "68516331", "Doe" },
                    { 17, "Some Adress 16", new DateTime(1, 1, 1, 0, 0, 0, 521, DateTimeKind.Unspecified).AddTicks(3071), "Marcos", "avatar.png", "74086869", "Garcia" }
                });

            migrationBuilder.InsertData(
                table: "Contact",
                columns: new[] { "ID", "Addresses", "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[,]
                {
                    { 18, "Some Adress 17", new DateTime(1, 1, 1, 0, 0, 0, 335, DateTimeKind.Unspecified).AddTicks(3260), "Carlos", "avatar.png", "41980421", "Doe" },
                    { 19, "Some Adress 18", new DateTime(1, 1, 1, 0, 0, 0, 166, DateTimeKind.Unspecified).AddTicks(5456), "Jhon", "avatar.png", "14405129", "Hernandez" },
                    { 20, "Some Adress 19", new DateTime(1, 1, 1, 0, 0, 0, 510, DateTimeKind.Unspecified).AddTicks(2179), "Juliet", "avatar.png", "14229094", "Lee" },
                    { 21, "Some Adress 20", new DateTime(1, 1, 1, 0, 0, 0, 636, DateTimeKind.Unspecified).AddTicks(5801), "Juliet", "avatar.png", "30080898", "Fernandez" },
                    { 22, "Some Adress 21", new DateTime(1, 1, 1, 0, 0, 0, 489, DateTimeKind.Unspecified).AddTicks(7269), "Jhon", "avatar.png", "91630062", "Doe" },
                    { 23, "Some Adress 22", new DateTime(1, 1, 1, 0, 0, 0, 608, DateTimeKind.Unspecified).AddTicks(8930), "Tedd", "avatar.png", "21276578", "Tapanez" },
                    { 13, "Some Adress 12", new DateTime(1, 1, 1, 0, 0, 0, 668, DateTimeKind.Unspecified).AddTicks(1892), "Juliet", "avatar.png", "48481252", "Lee" },
                    { 50, "Some Adress 49", new DateTime(1, 1, 1, 0, 0, 0, 127, DateTimeKind.Unspecified).AddTicks(7457), "Juliet", "avatar.png", "38212128", "Fernandez" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contact");
        }
    }
}
