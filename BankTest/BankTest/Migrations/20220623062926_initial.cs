using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BankTest.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
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
                    { 1, "Some Adress 0", new DateTime(1973, 6, 23, 8, 29, 26, 268, DateTimeKind.Local).AddTicks(8489), "Marcos", "img_avatar2.png", "34510230", "Garcia" },
                    { 28, "Some Adress 27", new DateTime(1946, 6, 23, 8, 29, 26, 276, DateTimeKind.Local).AddTicks(3522), "Carlos", "img_avatar5.png", "43731259", "Tapanez" },
                    { 29, "Some Adress 28", new DateTime(1998, 6, 23, 8, 29, 26, 276, DateTimeKind.Local).AddTicks(3544), "Jhon", "img_avatar2.png", "17209292", "Garcia" },
                    { 30, "Some Adress 29", new DateTime(1972, 6, 23, 8, 29, 26, 276, DateTimeKind.Local).AddTicks(3562), "Carlos", "img_avatar5.png", "86839203", "Garcia" },
                    { 31, "Some Adress 30", new DateTime(1962, 6, 23, 8, 29, 26, 276, DateTimeKind.Local).AddTicks(3580), "Juliet", "img_avatar4.png", "46047277", "Hernandez" },
                    { 32, "Some Adress 31", new DateTime(1958, 6, 23, 8, 29, 26, 276, DateTimeKind.Local).AddTicks(3598), "Jhon", "img_avatar5.png", "57167407", "Fernandez" },
                    { 33, "Some Adress 32", new DateTime(1996, 6, 23, 8, 29, 26, 276, DateTimeKind.Local).AddTicks(3617), "Miguel", "img_avatar2.png", "83942255", "Fernandez" },
                    { 34, "Some Adress 33", new DateTime(1966, 6, 23, 8, 29, 26, 276, DateTimeKind.Local).AddTicks(3636), "Brayan", "img_avatar1.png", "42821420", "Doe" },
                    { 35, "Some Adress 34", new DateTime(2000, 6, 23, 8, 29, 26, 276, DateTimeKind.Local).AddTicks(3655), "Tedd", "img_avatar4.png", "18114039", "Stampton" },
                    { 36, "Some Adress 35", new DateTime(1957, 6, 23, 8, 29, 26, 276, DateTimeKind.Local).AddTicks(3673), "Carlos", "img_avatar2.png", "71871473", "Tapanez" },
                    { 37, "Some Adress 36", new DateTime(1965, 6, 23, 8, 29, 26, 276, DateTimeKind.Local).AddTicks(3691), "Juliet", "img_avatar1.png", "87133033", "Doe" },
                    { 38, "Some Adress 37", new DateTime(1979, 6, 23, 8, 29, 26, 276, DateTimeKind.Local).AddTicks(3709), "Marcos", "img_avatar2.png", "62874577", "Fernandez" },
                    { 39, "Some Adress 38", new DateTime(1982, 6, 23, 8, 29, 26, 276, DateTimeKind.Local).AddTicks(3726), "Brayan", "img_avatar2.png", "60936002", "Hernandez" },
                    { 40, "Some Adress 39", new DateTime(1985, 6, 23, 8, 29, 26, 276, DateTimeKind.Local).AddTicks(3744), "Miguel", "img_avatar1.png", "79134967", "Hernandez" },
                    { 41, "Some Adress 40", new DateTime(1998, 6, 23, 8, 29, 26, 276, DateTimeKind.Local).AddTicks(3819), "Tedd", "img_avatar3.png", "80540903", "Tapanez" },
                    { 42, "Some Adress 41", new DateTime(1968, 6, 23, 8, 29, 26, 276, DateTimeKind.Local).AddTicks(3839), "Brayan", "img_avatar1.png", "64740452", "Doe" },
                    { 43, "Some Adress 42", new DateTime(2006, 6, 23, 8, 29, 26, 276, DateTimeKind.Local).AddTicks(3857), "Jhon", "img_avatar5.png", "26498309", "Garcia" },
                    { 44, "Some Adress 43", new DateTime(1986, 6, 23, 8, 29, 26, 276, DateTimeKind.Local).AddTicks(3875), "Carlos", "img_avatar3.png", "75429943", "Lee" },
                    { 45, "Some Adress 44", new DateTime(2007, 6, 23, 8, 29, 26, 276, DateTimeKind.Local).AddTicks(3893), "Marcos", "img_avatar5.png", "15345470", "Stampton" },
                    { 46, "Some Adress 45", new DateTime(1970, 6, 23, 8, 29, 26, 276, DateTimeKind.Local).AddTicks(3911), "Brayan", "img_avatar1.png", "78290367", "Hernandez" },
                    { 47, "Some Adress 46", new DateTime(2010, 6, 23, 8, 29, 26, 276, DateTimeKind.Local).AddTicks(3929), "Brayan", "img_avatar5.png", "67549522", "Stampton" },
                    { 48, "Some Adress 47", new DateTime(1950, 6, 23, 8, 29, 26, 276, DateTimeKind.Local).AddTicks(3946), "Jhon", "img_avatar5.png", "34115009", "Tapanez" },
                    { 27, "Some Adress 26", new DateTime(1951, 6, 23, 8, 29, 26, 276, DateTimeKind.Local).AddTicks(3504), "Jhon", "img_avatar2.png", "30754663", "Doe" },
                    { 26, "Some Adress 25", new DateTime(1976, 6, 23, 8, 29, 26, 276, DateTimeKind.Local).AddTicks(3481), "Carlos", "img_avatar5.png", "85851043", "Stampton" },
                    { 25, "Some Adress 24", new DateTime(1951, 6, 23, 8, 29, 26, 276, DateTimeKind.Local).AddTicks(3411), "Juliet", "img_avatar5.png", "90248121", "Hernandez" },
                    { 24, "Some Adress 23", new DateTime(1974, 6, 23, 8, 29, 26, 276, DateTimeKind.Local).AddTicks(3393), "Tedd", "img_avatar5.png", "12309255", "Garcia" },
                    { 2, "Some Adress 1", new DateTime(2002, 6, 23, 8, 29, 26, 276, DateTimeKind.Local).AddTicks(1828), "Carlos", "img_avatar5.png", "70590154", "Stampton" },
                    { 3, "Some Adress 2", new DateTime(1946, 6, 23, 8, 29, 26, 276, DateTimeKind.Local).AddTicks(2515), "Brayan", "img_avatar4.png", "73435580", "Fernandez" },
                    { 4, "Some Adress 3", new DateTime(1981, 6, 23, 8, 29, 26, 276, DateTimeKind.Local).AddTicks(2558), "Jhon", "img_avatar4.png", "44399303", "Garcia" },
                    { 5, "Some Adress 4", new DateTime(1987, 6, 23, 8, 29, 26, 276, DateTimeKind.Local).AddTicks(2739), "Juliet", "img_avatar5.png", "87679068", "Lee" },
                    { 6, "Some Adress 5", new DateTime(1953, 6, 23, 8, 29, 26, 276, DateTimeKind.Local).AddTicks(2765), "Jhon", "img_avatar3.png", "93184862", "Garcia" },
                    { 7, "Some Adress 6", new DateTime(2003, 6, 23, 8, 29, 26, 276, DateTimeKind.Local).AddTicks(2785), "Juliet", "img_avatar3.png", "67544689", "Lee" },
                    { 8, "Some Adress 7", new DateTime(1973, 6, 23, 8, 29, 26, 276, DateTimeKind.Local).AddTicks(2804), "Carlos", "img_avatar2.png", "58953112", "Hernandez" },
                    { 9, "Some Adress 8", new DateTime(1943, 6, 23, 8, 29, 26, 276, DateTimeKind.Local).AddTicks(2823), "Brayan", "img_avatar1.png", "27762003", "Doe" },
                    { 10, "Some Adress 9", new DateTime(1945, 6, 23, 8, 29, 26, 276, DateTimeKind.Local).AddTicks(2843), "Tedd", "img_avatar2.png", "60371422", "Garcia" },
                    { 11, "Some Adress 10", new DateTime(1997, 6, 23, 8, 29, 26, 276, DateTimeKind.Local).AddTicks(2987), "Brayan", "img_avatar2.png", "23636350", "Lee" },
                    { 49, "Some Adress 48", new DateTime(1951, 6, 23, 8, 29, 26, 276, DateTimeKind.Local).AddTicks(3964), "Miguel", "img_avatar2.png", "47381610", "Stampton" },
                    { 12, "Some Adress 11", new DateTime(1963, 6, 23, 8, 29, 26, 276, DateTimeKind.Local).AddTicks(3009), "Jhon", "img_avatar1.png", "35436497", "Doe" },
                    { 14, "Some Adress 13", new DateTime(1991, 6, 23, 8, 29, 26, 276, DateTimeKind.Local).AddTicks(3208), "Carlos", "img_avatar2.png", "36811850", "Hernandez" },
                    { 15, "Some Adress 14", new DateTime(1949, 6, 23, 8, 29, 26, 276, DateTimeKind.Local).AddTicks(3227), "Juliet", "img_avatar2.png", "23727374", "Tapanez" },
                    { 16, "Some Adress 15", new DateTime(2001, 6, 23, 8, 29, 26, 276, DateTimeKind.Local).AddTicks(3244), "Juliet", "img_avatar3.png", "82906708", "Lee" },
                    { 17, "Some Adress 16", new DateTime(1992, 6, 23, 8, 29, 26, 276, DateTimeKind.Local).AddTicks(3262), "Miguel", "img_avatar2.png", "71018340", "Stampton" }
                });

            migrationBuilder.InsertData(
                table: "Contact",
                columns: new[] { "ID", "Addresses", "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[,]
                {
                    { 18, "Some Adress 17", new DateTime(1944, 6, 23, 8, 29, 26, 276, DateTimeKind.Local).AddTicks(3284), "Jhon", "img_avatar3.png", "48758256", "Garcia" },
                    { 19, "Some Adress 18", new DateTime(1993, 6, 23, 8, 29, 26, 276, DateTimeKind.Local).AddTicks(3303), "Tedd", "img_avatar2.png", "44674159", "Garcia" },
                    { 20, "Some Adress 19", new DateTime(1960, 6, 23, 8, 29, 26, 276, DateTimeKind.Local).AddTicks(3321), "Tedd", "img_avatar3.png", "35391558", "Lee" },
                    { 21, "Some Adress 20", new DateTime(1966, 6, 23, 8, 29, 26, 276, DateTimeKind.Local).AddTicks(3339), "Brayan", "img_avatar2.png", "39917969", "Hernandez" },
                    { 22, "Some Adress 21", new DateTime(2007, 6, 23, 8, 29, 26, 276, DateTimeKind.Local).AddTicks(3357), "Brayan", "img_avatar2.png", "79884981", "Tapanez" },
                    { 23, "Some Adress 22", new DateTime(1950, 6, 23, 8, 29, 26, 276, DateTimeKind.Local).AddTicks(3375), "Brayan", "img_avatar3.png", "73628360", "Tapanez" },
                    { 13, "Some Adress 12", new DateTime(1997, 6, 23, 8, 29, 26, 276, DateTimeKind.Local).AddTicks(3190), "Juliet", "img_avatar5.png", "31159873", "Lee" },
                    { 50, "Some Adress 49", new DateTime(1995, 6, 23, 8, 29, 26, 276, DateTimeKind.Local).AddTicks(3982), "Miguel", "img_avatar5.png", "72701298", "Doe" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contact");
        }
    }
}
