using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BankTest.Migrations
{
    public partial class addeedEntityBase1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1944, 6, 20, 8, 26, 20, 623, DateTimeKind.Local).AddTicks(8016), "Juliet", "img_avatar4.png", "34147601", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1992, 6, 20, 8, 26, 20, 628, DateTimeKind.Local).AddTicks(4445), "Juliet", "img_avatar4.png", "76755930", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1959, 6, 20, 8, 26, 20, 628, DateTimeKind.Local).AddTicks(4679), "Brayan", "img_avatar4.png", "66349388", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1997, 6, 20, 8, 26, 20, 628, DateTimeKind.Local).AddTicks(4790), "Juliet", "81725871", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1978, 6, 20, 8, 26, 20, 628, DateTimeKind.Local).AddTicks(4813), "Brayan", "img_avatar3.png", "27857148", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1949, 6, 20, 8, 26, 20, 628, DateTimeKind.Local).AddTicks(4836), "Juliet", "img_avatar2.png", "92687141", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1997, 6, 20, 8, 26, 20, 628, DateTimeKind.Local).AddTicks(4855), "Brayan", "img_avatar1.png", "60573828", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1988, 6, 20, 8, 26, 20, 628, DateTimeKind.Local).AddTicks(4873), "Juliet", "img_avatar2.png", "48252628", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1982, 6, 20, 8, 26, 20, 628, DateTimeKind.Local).AddTicks(4890), "Brayan", "img_avatar2.png", "83834656", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1977, 6, 20, 8, 26, 20, 628, DateTimeKind.Local).AddTicks(4908), "Carlos", "img_avatar4.png", "72393690", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(2011, 6, 20, 8, 26, 20, 628, DateTimeKind.Local).AddTicks(4927), "Miguel", "img_avatar2.png", "89461406" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1958, 6, 20, 8, 26, 20, 628, DateTimeKind.Local).AddTicks(4944), "Marcos", "img_avatar4.png", "87180521", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1987, 6, 20, 8, 26, 20, 628, DateTimeKind.Local).AddTicks(4962), "Carlos", "img_avatar3.png", "52886480" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1998, 6, 20, 8, 26, 20, 628, DateTimeKind.Local).AddTicks(4979), "Carlos", "img_avatar4.png", "55129092", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1956, 6, 20, 8, 26, 20, 628, DateTimeKind.Local).AddTicks(4995), "Jhon", "img_avatar4.png", "51511129", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1966, 6, 20, 8, 26, 20, 628, DateTimeKind.Local).AddTicks(5013), "Marcos", "img_avatar5.png", "86224335" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1997, 6, 20, 8, 26, 20, 628, DateTimeKind.Local).AddTicks(5030), "Jhon", "img_avatar3.png", "22779415", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1988, 6, 20, 8, 26, 20, 628, DateTimeKind.Local).AddTicks(5048), "Tedd", "img_avatar2.png", "32835427", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1978, 6, 20, 8, 26, 20, 628, DateTimeKind.Local).AddTicks(5116), "Marcos", "68135772", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1945, 6, 20, 8, 26, 20, 628, DateTimeKind.Local).AddTicks(5134), "Tedd", "img_avatar5.png", "37882916", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2012, 6, 20, 8, 26, 20, 628, DateTimeKind.Local).AddTicks(5151), "Tedd", "91619549", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1973, 6, 20, 8, 26, 20, 628, DateTimeKind.Local).AddTicks(5168), "Carlos", "21164389", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1947, 6, 20, 8, 26, 20, 628, DateTimeKind.Local).AddTicks(5185), "Jhon", "92656963", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1997, 6, 20, 8, 26, 20, 628, DateTimeKind.Local).AddTicks(5202), "Miguel", "img_avatar2.png", "92436521", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "DateofBirth", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1946, 6, 20, 8, 26, 20, 628, DateTimeKind.Local).AddTicks(5219), "img_avatar5.png", "24528717", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2002, 6, 20, 8, 26, 20, 628, DateTimeKind.Local).AddTicks(5235), "Juliet", "img_avatar3.png", "68111636", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1987, 6, 20, 8, 26, 20, 628, DateTimeKind.Local).AddTicks(5253), "Miguel", "img_avatar3.png", "11810636" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1991, 6, 20, 8, 26, 20, 628, DateTimeKind.Local).AddTicks(5270), "Tedd", "46759947", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1997, 6, 20, 8, 26, 20, 628, DateTimeKind.Local).AddTicks(5287), "Jhon", "70169558", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1972, 6, 20, 8, 26, 20, 628, DateTimeKind.Local).AddTicks(5304), "Carlos", "img_avatar2.png", "91315957" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2009, 6, 20, 8, 26, 20, 628, DateTimeKind.Local).AddTicks(5321), "Miguel", "18987690", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "DateofBirth", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1954, 6, 20, 8, 26, 20, 628, DateTimeKind.Local).AddTicks(5337), "img_avatar4.png", "97679828", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1949, 6, 20, 8, 26, 20, 628, DateTimeKind.Local).AddTicks(5354), "Marcos", "img_avatar1.png", "71716163" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1949, 6, 20, 8, 26, 20, 628, DateTimeKind.Local).AddTicks(5418), "Carlos", "img_avatar2.png", "41574101" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1955, 6, 20, 8, 26, 20, 628, DateTimeKind.Local).AddTicks(5438), "Miguel", "img_avatar1.png", "84371109", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1993, 6, 20, 8, 26, 20, 628, DateTimeKind.Local).AddTicks(5486), "Marcos", "img_avatar3.png", "96196029", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1995, 6, 20, 8, 26, 20, 628, DateTimeKind.Local).AddTicks(5504), "Juliet", "46270468", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1994, 6, 20, 8, 26, 20, 628, DateTimeKind.Local).AddTicks(5521), "Miguel", "img_avatar5.png", "19445758", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1989, 6, 20, 8, 26, 20, 628, DateTimeKind.Local).AddTicks(5538), "Marcos", "img_avatar2.png", "69832619", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1975, 6, 20, 8, 26, 20, 628, DateTimeKind.Local).AddTicks(5555), "Jhon", "img_avatar4.png", "69969116", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1997, 6, 20, 8, 26, 20, 628, DateTimeKind.Local).AddTicks(5572), "Carlos", "img_avatar4.png", "61534048", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1997, 6, 20, 8, 26, 20, 628, DateTimeKind.Local).AddTicks(5588), "Brayan", "img_avatar1.png", "11893970", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1951, 6, 20, 8, 26, 20, 628, DateTimeKind.Local).AddTicks(5605), "Jhon", "img_avatar5.png", "59237584" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "DateofBirth", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1977, 6, 20, 8, 26, 20, 628, DateTimeKind.Local).AddTicks(5622), "img_avatar2.png", "86610184" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1956, 6, 20, 8, 26, 20, 628, DateTimeKind.Local).AddTicks(5639), "Marcos", "img_avatar3.png", "46021665", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2002, 6, 20, 8, 26, 20, 628, DateTimeKind.Local).AddTicks(5656), "Carlos", "img_avatar5.png", "52357205", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1969, 6, 20, 8, 26, 20, 628, DateTimeKind.Local).AddTicks(5673), "Miguel", "img_avatar5.png", "28717188", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1965, 6, 20, 8, 26, 20, 628, DateTimeKind.Local).AddTicks(5689), "Miguel", "img_avatar4.png", "80938918" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1996, 6, 20, 8, 26, 20, 628, DateTimeKind.Local).AddTicks(5752), "Miguel", "img_avatar5.png", "14175314", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1957, 6, 20, 8, 26, 20, 628, DateTimeKind.Local).AddTicks(5771), "Tedd", "img_avatar4.png", "81199315", "Hernandez" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1971, 6, 20, 8, 24, 16, 505, DateTimeKind.Local).AddTicks(962), "Tedd", "img_avatar1.png", "57458843", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2005, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(6549), "Miguel", "img_avatar3.png", "60809378", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1945, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7051), "Jhon", "img_avatar2.png", "73603554", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2007, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7096), "Marcos", "48153440", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1956, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7122), "Carlos", "img_avatar4.png", "96883936", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1992, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7149), "Brayan", "img_avatar1.png", "58535167", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1976, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7170), "Jhon", "img_avatar4.png", "90329650", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2005, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7190), "Miguel", "img_avatar4.png", "20758542", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1975, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7210), "Juliet", "img_avatar4.png", "14173980", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2008, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7231), "Juliet", "img_avatar3.png", "95865415", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(2010, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7251), "Tedd", "img_avatar1.png", "51359263" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1968, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7272), "Jhon", "img_avatar5.png", "89290516", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1973, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7292), "Marcos", "img_avatar2.png", "59516514" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2008, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7311), "Juliet", "img_avatar3.png", "95418698", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1945, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7330), "Juliet", "img_avatar1.png", "76030078", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1959, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7526), "Miguel", "img_avatar4.png", "39923151" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1989, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7554), "Tedd", "img_avatar4.png", "12624451", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2008, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7577), "Brayan", "img_avatar4.png", "78756894", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1997, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7598), "Juliet", "23427955", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1943, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7618), "Juliet", "img_avatar4.png", "72263250", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2004, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7637), "Marcos", "42543858", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1991, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7656), "Miguel", "40249616", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1992, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7676), "Carlos", "29664430", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1975, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7695), "Jhon", "img_avatar1.png", "85014162", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "DateofBirth", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1991, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7714), "img_avatar4.png", "35509647", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1955, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7734), "Carlos", "img_avatar1.png", "89370274", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(2008, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7753), "Tedd", "img_avatar5.png", "67723344" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1944, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7773), "Carlos", "46918609", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1961, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7793), "Tedd", "30627746", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(2012, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7812), "Marcos", "img_avatar4.png", "58045492" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2002, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7884), "Tedd", "60033298", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "DateofBirth", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1954, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7906), "img_avatar1.png", "66951804", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1983, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7926), "Jhon", "img_avatar2.png", "24779799" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1966, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7948), "Marcos", "img_avatar1.png", "43422660" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2004, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7998), "Carlos", "img_avatar5.png", "73324967", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2007, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(8018), "Jhon", "img_avatar5.png", "14917481", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1993, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(8038), "Carlos", "19692824", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1977, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(8057), "Carlos", "img_avatar1.png", "84595192", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1989, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(8077), "Jhon", "img_avatar1.png", "41474135", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1973, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(8096), "Brayan", "img_avatar3.png", "98722102", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1968, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(8115), "Marcos", "img_avatar2.png", "53242922", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1981, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(8135), "Miguel", "img_avatar4.png", "76305280", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1958, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(8154), "Tedd", "img_avatar3.png", "74629412" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "DateofBirth", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1991, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(8173), "img_avatar4.png", "39457789" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1955, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(8192), "Brayan", "img_avatar5.png", "31426369", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1958, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(8263), "Miguel", "img_avatar3.png", "70220895", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2006, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(8283), "Marcos", "img_avatar1.png", "63747766", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1956, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(8303), "Brayan", "img_avatar1.png", "79215377" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1958, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(8322), "Juliet", "img_avatar4.png", "21907875", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1969, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(8341), "Miguel", "img_avatar3.png", "83229788", "Doe" });
        }
    }
}
