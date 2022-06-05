using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BankTest.Migrations
{
    public partial class newM2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1987, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tedd", "87958973", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1998, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Miguel", "19551593", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2012, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Juliet", "43625596", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1982, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marcos", "80905788", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1986, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carlos", "70246596", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1960, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brayan", "77886729", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1993, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marcos", "46005110", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1986, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Miguel", "71784672", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2008, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carlos", "43006715", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1980, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carlos", "16358656", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1949, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Juliet", "54495174" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1981, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tedd", "28614865", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2000, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tedd", "62043325", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2008, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brayan", "32348740", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2003, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marcos", "22979077", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1978, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Juliet", "85917695" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1948, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brayan", "74368244", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1995, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tedd", "26247413" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1961, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carlos", "47683867", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1984, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "79600236", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2008, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Juliet", "25612098", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "DateofBirth", "PhoneNumber" },
                values: new object[] { new DateTime(1981, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "33644355" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1970, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jhon", "94036812", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(2004, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brayan", "20206207" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1997, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tedd", "12309551" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1955, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jhon", "33394848", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2003, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brayan", "93848215", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2006, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "54959378", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2001, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brayan", "88613262", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1948, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "52037024", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1964, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Juliet", "61553794", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1943, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carlos", "21447065", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2008, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brayan", "18319024", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1961, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jhon", "32872064", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1944, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brayan", "92904952", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1955, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "44937849", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1961, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marcos", "84821567", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1987, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brayan", "13297615" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2002, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brayan", "44391259", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1957, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jhon", "89143212", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1960, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jhon", "83691131", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1980, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Miguel", "83512003", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1969, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Miguel", "95020949", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1957, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tedd", "42202204", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1953, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marcos", "42379520", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1944, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "94423452", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1946, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brayan", "34922501", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1998, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brayan", "10498472", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1948, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jhon", "69326837", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1956, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marcos", "75866473", "Tapanez" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1961, 6, 3, 16, 38, 12, 312, DateTimeKind.Local).AddTicks(9313), "Tedd", "16623313", "Garcia" });

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
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1961, 6, 3, 16, 38, 12, 312, DateTimeKind.Local).AddTicks(9645), "Carlos", "32902512", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1950, 6, 3, 16, 38, 12, 312, DateTimeKind.Local).AddTicks(9664), "Marcos", "15968170", "Fernandez" });

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
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1993, 6, 3, 16, 38, 12, 312, DateTimeKind.Local).AddTicks(9705), "Juliet", "96684897", "Stampton" });

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
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2006, 6, 3, 16, 38, 12, 312, DateTimeKind.Local).AddTicks(9760), "Brayan", "18076775", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1989, 6, 3, 16, 38, 12, 312, DateTimeKind.Local).AddTicks(9779), "Brayan", "58322755" });

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
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(2008, 6, 3, 16, 38, 12, 312, DateTimeKind.Local).AddTicks(9926), "Brayan", "40002217" });

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
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(2006, 6, 3, 16, 38, 12, 312, DateTimeKind.Local).AddTicks(9966), "Marcos", "83436226" });

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
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2012, 6, 3, 16, 38, 12, 313, DateTimeKind.Local).AddTicks(17), "Brayan", "64029925", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "DateofBirth", "PhoneNumber" },
                values: new object[] { new DateTime(2009, 6, 3, 16, 38, 12, 313, DateTimeKind.Local).AddTicks(34), "70674821" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1989, 6, 3, 16, 38, 12, 313, DateTimeKind.Local).AddTicks(51), "Marcos", "66832341", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1947, 6, 3, 16, 38, 12, 313, DateTimeKind.Local).AddTicks(67), "Juliet", "46667863" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1957, 6, 3, 16, 38, 12, 313, DateTimeKind.Local).AddTicks(84), "Marcos", "82453603" });

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
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1993, 6, 3, 16, 38, 12, 313, DateTimeKind.Local).AddTicks(134), "94871139", "Fernandez" });

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
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1985, 6, 3, 16, 38, 12, 313, DateTimeKind.Local).AddTicks(167), "89642932", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1972, 6, 3, 16, 38, 12, 313, DateTimeKind.Local).AddTicks(227), "Miguel", "26662903", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1955, 6, 3, 16, 38, 12, 313, DateTimeKind.Local).AddTicks(247), "Marcos", "96996608", "Garcia" });

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
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2001, 6, 3, 16, 38, 12, 313, DateTimeKind.Local).AddTicks(317), "40414626", "Fernandez" });

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
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1968, 6, 3, 16, 38, 12, 313, DateTimeKind.Local).AddTicks(352), "Marcos", "35528687" });

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
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1987, 6, 3, 16, 38, 12, 313, DateTimeKind.Local).AddTicks(419), "Brayan", "96224330", "Doe" });

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
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2000, 6, 3, 16, 38, 12, 313, DateTimeKind.Local).AddTicks(564), "64357897", "Stampton" });

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
    }
}
