using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BankTest.Migrations
{
    public partial class formatdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2000, 6, 3, 16, 26, 48, 91, DateTimeKind.Local).AddTicks(928), "Jhon", "17336685", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1947, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(2629), "Brayan", "17608081", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1966, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(3223), "Miguel", "72111981", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1943, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(3258), "Tedd", "95376215" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1956, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(3278), "Carlos", "71479389", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1944, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(3306), "Brayan", "92999690", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1958, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(3324), "12593125", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1953, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(3342), "Carlos", "78629653" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2009, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(3359), "Miguel", "26101281", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1965, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(3378), "Tedd", "18356030", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(2009, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(3396), "Juliet", "21674340" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1959, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(3415), "Juliet", "76894160", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1945, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(3432), "Brayan", "52973362", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1999, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(3450), "Tedd", "14032700", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1951, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(3467), "Carlos", "37928152", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1975, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(3484), "Tedd", "12418982", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2010, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(3581), "13076999", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1975, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(3607), "Jhon", "73114875", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1961, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(3626), "Juliet", "54472254", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1944, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(3644), "Jhon", "61360709" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1960, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(3662), "Brayan", "33446566", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1986, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(3679), "Miguel", "88742417", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1961, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(3697), "Jhon", "23701436", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1962, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(3714), "Juliet", "13963127", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1988, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(3731), "Brayan", "14419730", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1962, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(3748), "Miguel", "51947746" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1972, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(3766), "Marcos", "70720639" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2011, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(3784), "Jhon", "63292392", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2003, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(3801), "Brayan", "40510048", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1987, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(3818), "Brayan", "47014560", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1946, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(3835), "Carlos", "10906145", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1961, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(3903), "Jhon", "56768416", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1989, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(3927), "Juliet", "99972968", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1944, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(3946), "Carlos", "51018563", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1977, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(3966), "Tedd", "45320851", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1954, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(3983), "Marcos", "45253143", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1952, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(4001), "Juliet", "69382341", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1950, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(4019), "Brayan", "90098365", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1976, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(4037), "Miguel", "49141539" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1985, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(4054), "Marcos", "42929517", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1965, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(4072), "Carlos", "41584422", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2006, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(4089), "Tedd", "42370239", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2010, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(4107), "Tedd", "87970470", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1969, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(4124), "Marcos", "84509445", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2010, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(4142), "Tedd", "94365155", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1993, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(4159), "Carlos", "64899280", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1988, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(4231), "Marcos", "60686877", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1965, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(4252), "Tedd", "63267722", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1953, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(4269), "Juliet", "74636464", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2011, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(4287), "Jhon", "95731405", "Garcia" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 201, DateTimeKind.Unspecified).AddTicks(7968), "Brayan", "64438592", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 606, DateTimeKind.Unspecified).AddTicks(8433), "Tedd", "17850619", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 822, DateTimeKind.Unspecified).AddTicks(6207), "Tedd", "47162071", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 313, DateTimeKind.Unspecified).AddTicks(4644), "Miguel", "77440155" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 578, DateTimeKind.Unspecified).AddTicks(9046), "Tedd", "83567678", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 183, DateTimeKind.Unspecified).AddTicks(2314), "Miguel", "77548711", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 557, DateTimeKind.Unspecified).AddTicks(5941), "54877433", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 551, DateTimeKind.Unspecified).AddTicks(6597), "Juliet", "34442303" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 669, DateTimeKind.Unspecified).AddTicks(7169), "Juliet", "29160323", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 927, DateTimeKind.Unspecified).AddTicks(6606), "Carlos", "32247470", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 601, DateTimeKind.Unspecified).AddTicks(254), "Marcos", "34726564" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 567, DateTimeKind.Unspecified).AddTicks(8563), "Tedd", "24351959", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 668, DateTimeKind.Unspecified).AddTicks(1892), "Juliet", "48481252", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 582, DateTimeKind.Unspecified).AddTicks(8460), "Marcos", "73861815", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 395, DateTimeKind.Unspecified).AddTicks(130), "Miguel", "89208886", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 207, DateTimeKind.Unspecified).AddTicks(4716), "Carlos", "68516331", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 521, DateTimeKind.Unspecified).AddTicks(3071), "74086869", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 335, DateTimeKind.Unspecified).AddTicks(3260), "Carlos", "41980421", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 166, DateTimeKind.Unspecified).AddTicks(5456), "Jhon", "14405129", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 510, DateTimeKind.Unspecified).AddTicks(2179), "Juliet", "14229094" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 636, DateTimeKind.Unspecified).AddTicks(5801), "Juliet", "30080898", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 489, DateTimeKind.Unspecified).AddTicks(7269), "Jhon", "91630062", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 608, DateTimeKind.Unspecified).AddTicks(8930), "Tedd", "21276578", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 711, DateTimeKind.Unspecified).AddTicks(8604), "Miguel", "71106215", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 600, DateTimeKind.Unspecified).AddTicks(3090), "Carlos", "78707150", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 726, DateTimeKind.Unspecified).AddTicks(9274), "Marcos", "89033297" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 447, DateTimeKind.Unspecified).AddTicks(447), "Carlos", "59826613" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 823, DateTimeKind.Unspecified).AddTicks(9111), "Juliet", "84674432", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 986, DateTimeKind.Unspecified).AddTicks(6587), "Juliet", "29653971", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 619, DateTimeKind.Unspecified).AddTicks(3055), "Carlos", "68010938", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 371, DateTimeKind.Unspecified).AddTicks(6032), "Jhon", "58549335", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 695, DateTimeKind.Unspecified).AddTicks(3379), "Carlos", "10219598", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 636, DateTimeKind.Unspecified).AddTicks(698), "Miguel", "99884480", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 356, DateTimeKind.Unspecified).AddTicks(5161), "Brayan", "17844253", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 765, DateTimeKind.Unspecified).AddTicks(9094), "Miguel", "81747270", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 948, DateTimeKind.Unspecified).AddTicks(8332), "Miguel", "93047067", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 296, DateTimeKind.Unspecified).AddTicks(6739), "Jhon", "47174406", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 289, DateTimeKind.Unspecified).AddTicks(5732), "Jhon", "60131879", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 698, DateTimeKind.Unspecified).AddTicks(6008), "Tedd", "28076827" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 477, DateTimeKind.Unspecified).AddTicks(3647), "Carlos", "41233923", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 953, DateTimeKind.Unspecified).AddTicks(6966), "Miguel", "61198392", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 611, DateTimeKind.Unspecified).AddTicks(875), "Juliet", "29294536", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 609, DateTimeKind.Unspecified).AddTicks(3925), "Juliet", "77524176", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 960, DateTimeKind.Unspecified).AddTicks(3069), "Brayan", "29700983", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 478, DateTimeKind.Unspecified).AddTicks(3056), "Miguel", "75081944", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 953, DateTimeKind.Unspecified).AddTicks(2828), "Juliet", "22924874", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 702, DateTimeKind.Unspecified).AddTicks(2881), "Brayan", "41545708", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 623, DateTimeKind.Unspecified).AddTicks(582), "Jhon", "54571307", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 264, DateTimeKind.Unspecified).AddTicks(4256), "Tedd", "37495365", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 127, DateTimeKind.Unspecified).AddTicks(7457), "Juliet", "38212128", "Fernandez" });
        }
    }
}
