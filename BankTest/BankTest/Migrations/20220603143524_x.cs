using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BankTest.Migrations
{
    public partial class x : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1969, 6, 3, 16, 35, 24, 484, DateTimeKind.Local).AddTicks(5992), "Tedd", "89455904", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1963, 6, 3, 16, 35, 24, 489, DateTimeKind.Local).AddTicks(9774), "Tedd", "54040636", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1955, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(104), "94468128", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1967, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(136), "Marcos", "93474329", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1973, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(154), "Miguel", "31647375", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1970, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(177), "Carlos", "12195180", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1950, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(196), "Tedd", "83556445", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2002, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(213), "30040244", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1953, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(231), "Brayan", "24977963", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1947, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(249), "Jhon", "54812582", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1946, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(268), "Brayan", "57046074", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1983, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(284), "Jhon", "85315823", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1968, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(301), "Jhon", "84097475", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1955, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(318), "Brayan", "27633972", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1976, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(335), "Marcos", "71228549", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1947, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(353), "Juliet", "42317905" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1959, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(469), "Brayan", "89624763", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1948, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(488), "Juliet", "73845081", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1945, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(505), "Tedd", "73828044", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1948, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(522), "Brayan", "81430667", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "DateofBirth", "PhoneNumber" },
                values: new object[] { new DateTime(1958, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(538), "54591593" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "DateofBirth", "PhoneNumber" },
                values: new object[] { new DateTime(1945, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(555), "63718576" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1986, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(571), "46897401", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1973, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(587), "Tedd", "44373899", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1989, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(603), "Marcos", "55532226", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1948, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(620), "Marcos", "60374939", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1981, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(636), "Jhon", "26307650", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1944, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(653), "Miguel", "72888287", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1982, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(670), "Miguel", "88870007", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1966, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(686), "Jhon", "87524206", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1959, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(702), "Miguel", "33731167" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1987, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(763), "20507805", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1952, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(782), "Carlos", "66173873" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1943, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(801), "Marcos", "73603773", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1987, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(818), "Jhon", "79799262" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1944, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(834), "Juliet", "11592701", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1961, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(850), "Miguel", "65043867", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1994, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(866), "Marcos", "46830931", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1951, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(882), "Juliet", "67736479", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1981, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(899), "65456227", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1965, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(915), "12389777", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1946, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(931), "Brayan", "33408866", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1961, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(948), "Marcos", "91560514", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1943, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(964), "Jhon", "85481481" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1972, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(980), "Brayan", "48599173", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1992, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(1052), "Marcos", "82993274", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1964, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(1071), "Tedd", "34580808" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1947, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(1087), "Carlos", "53367935", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1997, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(1104), "Marcos", "58002641", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1958, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(1120), "39610946", "Tapanez" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1966, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(3223), "72111981", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1943, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(3258), "Tedd", "95376215", "Doe" });

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
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1958, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(3324), "Brayan", "12593125", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1953, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(3342), "78629653", "Stampton" });

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
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2009, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(3396), "Juliet", "21674340", "Stampton" });

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
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1975, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(3484), "Tedd", "12418982" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2010, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(3581), "Marcos", "13076999", "Tapanez" });

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
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1944, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(3644), "Jhon", "61360709", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "DateofBirth", "PhoneNumber" },
                values: new object[] { new DateTime(1960, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(3662), "33446566" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "DateofBirth", "PhoneNumber" },
                values: new object[] { new DateTime(1986, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(3679), "88742417" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1961, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(3697), "23701436", "Doe" });

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
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1962, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(3748), "Miguel", "51947746", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1972, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(3766), "Marcos", "70720639", "Hernandez" });

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
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1946, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(3835), "Carlos", "10906145" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1961, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(3903), "56768416", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1989, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(3927), "Juliet", "99972968" });

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
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1977, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(3966), "Tedd", "45320851" });

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
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1976, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(4037), "Miguel", "49141539", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1985, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(4054), "42929517", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1965, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(4072), "41584422", "Doe" });

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
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1969, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(4124), "Marcos", "84509445" });

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
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1988, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(4231), "Marcos", "60686877" });

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
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2011, 6, 3, 16, 26, 48, 96, DateTimeKind.Local).AddTicks(4287), "95731405", "Garcia" });
        }
    }
}
