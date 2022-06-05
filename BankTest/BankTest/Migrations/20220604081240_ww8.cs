using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BankTest.Migrations
{
    public partial class ww8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1963, 6, 4, 10, 12, 40, 525, DateTimeKind.Local).AddTicks(8311), "Brayan", "img_avatar3.png", "81359605", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1986, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4344), "Miguel", "img_avatar3.png", "53493277", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1971, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4570), "Juliet", "img_avatar1.png", "19970092", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(2004, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4605), "Carlos", "96570026" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1966, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4624), "Carlos", "img_avatar4.png", "25772747", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1967, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4645), "Miguel", "img_avatar1.png", "52770248", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1955, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4664), "Marcos", "img_avatar4.png", "53958282" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1953, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4680), "Marcos", "img_avatar4.png", "92516426", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1972, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4760), "Juliet", "img_avatar5.png", "84730732", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1991, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4780), "Carlos", "img_avatar5.png", "69754816", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1968, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4796), "Miguel", "img_avatar1.png", "86959833", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1975, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4814), "Tedd", "img_avatar4.png", "10321450", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateofBirth", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1949, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4830), "img_avatar4.png", "45621266", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2005, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4846), "Marcos", "39342210", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateofBirth", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1998, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4862), "img_avatar3.png", "31873366", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1954, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4878), "Marcos", "img_avatar2.png", "31862972", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1943, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4894), "Juliet", "img_avatar3.png", "56475357", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1944, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4911), "Tedd", "img_avatar2.png", "45763964", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateofBirth", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1954, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4928), "img_avatar2.png", "21104236", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2000, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4944), "Brayan", "img_avatar1.png", "25925944", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1943, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4961), "Brayan", "img_avatar5.png", "36531459", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1985, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4977), "Tedd", "img_avatar2.png", "38754307", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1992, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4993), "Brayan", "70011474", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1985, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5051), "Carlos", "img_avatar2.png", "90765398", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "DateofBirth", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1963, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5069), "img_avatar5.png", "94508817", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2007, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5085), "Jhon", "img_avatar2.png", "90287950", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1966, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5101), "Jhon", "img_avatar1.png", "24932982", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1964, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5117), "Brayan", "img_avatar2.png", "59038455", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1967, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5132), "Brayan", "img_avatar2.png", "20633372", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2000, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5149), "Juliet", "img_avatar5.png", "27713059", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1993, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5165), "Carlos", "img_avatar4.png", "92973246", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2009, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5181), "Jhon", "img_avatar5.png", "43596121", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1977, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5197), "Marcos", "img_avatar2.png", "11476456", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2004, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5215), "Brayan", "img_avatar4.png", "62948382", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1953, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5232), "Carlos", "img_avatar1.png", "72737688", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1971, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5248), "Carlos", "img_avatar5.png", "76401054" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1951, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5264), "Tedd", "98994730", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1961, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5280), "Marcos", "img_avatar1.png", "59378092", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1990, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5420), "Brayan", "img_avatar2.png", "62795045", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "DateofBirth", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1968, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5439), "img_avatar1.png", "91740062", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1971, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5455), "Brayan", "img_avatar2.png", "54076713", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1971, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5472), "Tedd", "img_avatar1.png", "86577617", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1991, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5489), "Carlos", "img_avatar4.png", "50132924", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1976, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5505), "25738739", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1972, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5521), "Tedd", "img_avatar3.png", "59226707", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1995, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5537), "Miguel", "img_avatar1.png", "41031395", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1965, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5553), "Juliet", "img_avatar4.png", "72186539", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1985, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5569), "Marcos", "img_avatar3.png", "63907733", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1950, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5585), "Brayan", "img_avatar3.png", "45525049" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1951, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5602), "Juliet", "img_avatar4.png", "96044041", "Stampton" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2008, 6, 4, 10, 11, 50, 571, DateTimeKind.Local).AddTicks(9408), "Marcos", "img_avatar1.png", "45076636", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1951, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(1427), "Tedd", "img_avatar4.png", "79612147", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1997, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(1937), "Brayan", "img_avatar5.png", "55477666", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(2011, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2056), "Juliet", "15834745" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1980, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2084), "Juliet", "img_avatar1.png", "40010584", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1962, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2111), "Jhon", "img_avatar4.png", "78798133", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1991, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2130), "Miguel", "img_avatar5.png", "62331062" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2007, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2148), "Miguel", "img_avatar5.png", "84798685", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1951, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2168), "Miguel", "img_avatar1.png", "46105097", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1946, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2187), "Miguel", "img_avatar1.png", "62111441", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1986, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2205), "Juliet", "img_avatar3.png", "19378248", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1962, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2225), "Brayan", "img_avatar1.png", "29195358", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateofBirth", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2004, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2243), "img_avatar5.png", "22936505", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1968, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2261), "Brayan", "62595291", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateofBirth", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1999, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2279), "img_avatar5.png", "21296601", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2008, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2297), "Carlos", "img_avatar3.png", "37352767", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2003, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2315), "Jhon", "img_avatar4.png", "67139214", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1999, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2334), "Juliet", "img_avatar4.png", "11717788", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateofBirth", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1952, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2352), "img_avatar3.png", "82709174", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1961, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2418), "Jhon", "img_avatar5.png", "54677637", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1987, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2437), "Jhon", "img_avatar2.png", "43844514", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1995, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2454), "Juliet", "img_avatar1.png", "35489966", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1983, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2473), "Miguel", "69921246", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1979, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2490), "Tedd", "img_avatar1.png", "54549260", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "DateofBirth", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1969, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2508), "img_avatar4.png", "91620321", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1986, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2526), "Carlos", "img_avatar4.png", "59314587", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1973, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2544), "Brayan", "img_avatar3.png", "50308365", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1959, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2562), "Marcos", "img_avatar4.png", "45802447", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1948, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2580), "Tedd", "img_avatar1.png", "99590447", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1999, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2598), "Carlos", "img_avatar2.png", "89363163", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1996, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2616), "Marcos", "img_avatar2.png", "54349663", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1980, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2635), "Miguel", "img_avatar4.png", "75248157", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1963, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2653), "Miguel", "img_avatar5.png", "63167578", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1944, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2716), "Miguel", "img_avatar2.png", "22022861", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2006, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2738), "Miguel", "img_avatar4.png", "78102767", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1969, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2755), "Jhon", "img_avatar1.png", "83577659" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1977, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2773), "Miguel", "38040136", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2007, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2791), "Tedd", "img_avatar5.png", "17465817", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2010, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2808), "Juliet", "img_avatar1.png", "72053398", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "DateofBirth", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1990, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2826), "img_avatar3.png", "26214067", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2008, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2844), "Juliet", "img_avatar3.png", "71078762", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1979, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2862), "Brayan", "img_avatar2.png", "80008898", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1967, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2879), "Jhon", "img_avatar1.png", "58591074", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1985, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2897), "71277502", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1950, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2914), "Juliet", "img_avatar2.png", "28126532", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1985, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2932), "Carlos", "img_avatar4.png", "74530399", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1981, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2950), "Tedd", "img_avatar2.png", "45784177", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1955, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2967), "Miguel", "img_avatar4.png", "78681836", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1992, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2985), "Miguel", "img_avatar5.png", "80211998" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1978, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(3095), "Marcos", "img_avatar2.png", "61181391", "Garcia" });
        }
    }
}
