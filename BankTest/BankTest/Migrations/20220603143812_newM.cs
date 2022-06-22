using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BankTest.Migrations
{
    public partial class newM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1960, 6, 3, 16, 38, 12, 308, DateTimeKind.Local).AddTicks(1239), "Juliet", "96301868", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1961, 6, 3, 16, 38, 12, 312, DateTimeKind.Local).AddTicks(9313), "16623313", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1990, 6, 3, 16, 38, 12, 312, DateTimeKind.Local).AddTicks(9611), "Marcos", "53726758", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1961, 6, 3, 16, 38, 12, 312, DateTimeKind.Local).AddTicks(9645), "Carlos", "32902512" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1950, 6, 3, 16, 38, 12, 312, DateTimeKind.Local).AddTicks(9664), "Marcos", "15968170" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1949, 6, 3, 16, 38, 12, 312, DateTimeKind.Local).AddTicks(9687), "Marcos", "29709408", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1993, 6, 3, 16, 38, 12, 312, DateTimeKind.Local).AddTicks(9705), "Juliet", "96684897" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1992, 6, 3, 16, 38, 12, 312, DateTimeKind.Local).AddTicks(9723), "Jhon", "63613693", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2009, 6, 3, 16, 38, 12, 312, DateTimeKind.Local).AddTicks(9741), "Jhon", "69619803", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(2006, 6, 3, 16, 38, 12, 312, DateTimeKind.Local).AddTicks(9760), "Brayan", "18076775" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateofBirth", "PhoneNumber" },
                values: new object[] { new DateTime(1989, 6, 3, 16, 38, 12, 312, DateTimeKind.Local).AddTicks(9779), "58322755" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1990, 6, 3, 16, 38, 12, 312, DateTimeKind.Local).AddTicks(9796), "Carlos", "82896649", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1975, 6, 3, 16, 38, 12, 312, DateTimeKind.Local).AddTicks(9814), "Juliet", "49887687", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1985, 6, 3, 16, 38, 12, 312, DateTimeKind.Local).AddTicks(9830), "Carlos", "50843100", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1943, 6, 3, 16, 38, 12, 312, DateTimeKind.Local).AddTicks(9847), "Tedd", "81659176", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2008, 6, 3, 16, 38, 12, 312, DateTimeKind.Local).AddTicks(9926), "Brayan", "40002217", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1983, 6, 3, 16, 38, 12, 312, DateTimeKind.Local).AddTicks(9946), "Marcos", "41066179", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2006, 6, 3, 16, 38, 12, 312, DateTimeKind.Local).AddTicks(9966), "Marcos", "83436226", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1950, 6, 3, 16, 38, 12, 312, DateTimeKind.Local).AddTicks(9983), "Brayan", "97595181", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1964, 6, 3, 16, 38, 12, 313, DateTimeKind.Local), "21348760", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2012, 6, 3, 16, 38, 12, 313, DateTimeKind.Local).AddTicks(17), "64029925", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2009, 6, 3, 16, 38, 12, 313, DateTimeKind.Local).AddTicks(34), "Juliet", "70674821", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1989, 6, 3, 16, 38, 12, 313, DateTimeKind.Local).AddTicks(51), "Marcos", "66832341" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1947, 6, 3, 16, 38, 12, 313, DateTimeKind.Local).AddTicks(67), "Juliet", "46667863", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1957, 6, 3, 16, 38, 12, 313, DateTimeKind.Local).AddTicks(84), "82453603", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2010, 6, 3, 16, 38, 12, 313, DateTimeKind.Local).AddTicks(100), "Tedd", "90029060", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2000, 6, 3, 16, 38, 12, 313, DateTimeKind.Local).AddTicks(117), "Tedd", "77419027", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1993, 6, 3, 16, 38, 12, 313, DateTimeKind.Local).AddTicks(134), "Carlos", "94871139", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1977, 6, 3, 16, 38, 12, 313, DateTimeKind.Local).AddTicks(151), "Marcos", "71262773", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1985, 6, 3, 16, 38, 12, 313, DateTimeKind.Local).AddTicks(167), "Marcos", "89642932" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1972, 6, 3, 16, 38, 12, 313, DateTimeKind.Local).AddTicks(227), "26662903", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1955, 6, 3, 16, 38, 12, 313, DateTimeKind.Local).AddTicks(247), "Marcos", "96996608" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1996, 6, 3, 16, 38, 12, 313, DateTimeKind.Local).AddTicks(265), "Juliet", "25077048", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1964, 6, 3, 16, 38, 12, 313, DateTimeKind.Local).AddTicks(283), "Miguel", "38066675", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1993, 6, 3, 16, 38, 12, 313, DateTimeKind.Local).AddTicks(301), "Carlos", "30454528", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2001, 6, 3, 16, 38, 12, 313, DateTimeKind.Local).AddTicks(317), "Miguel", "40414626", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1957, 6, 3, 16, 38, 12, 313, DateTimeKind.Local).AddTicks(335), "Tedd", "22271670", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1968, 6, 3, 16, 38, 12, 313, DateTimeKind.Local).AddTicks(352), "35528687", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2004, 6, 3, 16, 38, 12, 313, DateTimeKind.Local).AddTicks(368), "Miguel", "71644377", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2001, 6, 3, 16, 38, 12, 313, DateTimeKind.Local).AddTicks(385), "Tedd", "86443030", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1950, 6, 3, 16, 38, 12, 313, DateTimeKind.Local).AddTicks(401), "Juliet", "12703952", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1987, 6, 3, 16, 38, 12, 313, DateTimeKind.Local).AddTicks(419), "96224330", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1996, 6, 3, 16, 38, 12, 313, DateTimeKind.Local).AddTicks(436), "Brayan", "69484435", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1998, 6, 3, 16, 38, 12, 313, DateTimeKind.Local).AddTicks(452), "Brayan", "44353980", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1951, 6, 3, 16, 38, 12, 313, DateTimeKind.Local).AddTicks(469), "Miguel", "39877372", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2000, 6, 3, 16, 38, 12, 313, DateTimeKind.Local).AddTicks(564), "Miguel", "64357897", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1974, 6, 3, 16, 38, 12, 313, DateTimeKind.Local).AddTicks(586), "Marcos", "70202061", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1948, 6, 3, 16, 38, 12, 313, DateTimeKind.Local).AddTicks(603), "Marcos", "63285182", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1990, 6, 3, 16, 38, 12, 313, DateTimeKind.Local).AddTicks(619), "Juliet", "51971768", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2003, 6, 3, 16, 38, 12, 313, DateTimeKind.Local).AddTicks(636), "Tedd", "27735707", "Doe" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1963, 6, 3, 16, 35, 24, 489, DateTimeKind.Local).AddTicks(9774), "54040636", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1955, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(104), "Miguel", "94468128", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1967, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(136), "Marcos", "93474329" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1973, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(154), "Miguel", "31647375" });

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
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1950, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(196), "Tedd", "83556445" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2002, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(213), "Carlos", "30040244", "Fernandez" });

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
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1947, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(249), "Jhon", "54812582" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateofBirth", "PhoneNumber" },
                values: new object[] { new DateTime(1946, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(268), "57046074" });

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
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1947, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(353), "Juliet", "42317905", "Tapanez" });

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
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1948, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(522), "81430667", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1958, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(538), "54591593", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1945, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(555), "Miguel", "63718576", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1986, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(571), "Jhon", "46897401" });

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
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1989, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(603), "55532226", "Stampton" });

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
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1966, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(686), "Jhon", "87524206" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1959, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(702), "33731167", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1987, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(763), "Jhon", "20507805" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1952, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(782), "Carlos", "66173873", "Stampton" });

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
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1987, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(818), "Jhon", "79799262", "Hernandez" });

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
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1994, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(866), "46830931", "Stampton" });

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
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1981, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(899), "Marcos", "65456227", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1965, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(915), "Carlos", "12389777", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1946, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(931), "33408866", "Fernandez" });

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
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1943, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(964), "Jhon", "85481481", "Tapanez" });

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
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1964, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(1071), "Tedd", "34580808", "Garcia" });

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
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1958, 6, 3, 16, 35, 24, 490, DateTimeKind.Local).AddTicks(1120), "Jhon", "39610946", "Tapanez" });
        }
    }
}
