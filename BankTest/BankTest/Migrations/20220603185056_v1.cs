using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BankTest.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Contact",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1989, 6, 3, 20, 50, 56, 581, DateTimeKind.Local).AddTicks(2417), "Brayan", "38338907", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1994, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(114), "Carlos", "39477243", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2009, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(517), "Jhon", "84816034", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1976, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(555), "Brayan", "55684259", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2000, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(575), "50127479", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1985, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(599), "Marcos", "35581955", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1994, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(617), "Juliet", "69918953" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1987, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(635), "Brayan", "57394351", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1945, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(651), "Jhon", "39159673", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1990, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(671), "27745902", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1953, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(688), "Tedd", "63882123" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1969, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(705), "Carlos", "51134272", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1982, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(722), "Marcos", "30526837", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1998, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(738), "Jhon", "86042836" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1983, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(755), "Jhon", "16691715", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2006, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(865), "Miguel", "72343579", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1957, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(883), "Miguel", "79706506", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1945, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(902), "Brayan", "10503454", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2006, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(920), "Miguel", "18437534", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1955, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(937), "Carlos", "15682837", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1950, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(954), "Marcos", "94090608", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1981, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(970), "86520120", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1991, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(988), "Brayan", "53808871", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1970, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1004), "Jhon", "78086288", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1943, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1021), "Miguel", "94622426", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "DateofBirth", "PhoneNumber" },
                values: new object[] { new DateTime(1992, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1037), "62107499" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1975, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1054), "Tedd", "18921810", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1993, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1070), "Jhon", "30116577", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "DateofBirth", "PhoneNumber" },
                values: new object[] { new DateTime(1991, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1086), "80621935" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1957, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1102), "Miguel", "52272266", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1972, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1340), "Jhon", "13363287", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1949, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1360), "Juliet", "50406199", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1981, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1377), "Tedd", "45699317", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2011, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1396), "Marcos", "93736304", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1970, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1414), "Carlos", "52286712", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1960, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1430), "17718112", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "DateofBirth", "PhoneNumber" },
                values: new object[] { new DateTime(1995, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1447), "76808528" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2009, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1464), "Juliet", "52820238", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1952, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1480), "Tedd", "19018480", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1964, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1497), "Brayan", "85988238" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1961, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1513), "Carlos", "78979622" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "DateofBirth", "PhoneNumber" },
                values: new object[] { new DateTime(1983, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1530), "41819648" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1993, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1546), "Tedd", "45159569", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1952, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1562), "Carlos", "74986689", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1999, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1579), "Brayan", "82022368", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1977, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1651), "Brayan", "58278318" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2011, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1668), "35643399", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1966, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1685), "Jhon", "32576276", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1947, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1701), "Miguel", "56759310", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1983, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1718), "Miguel", "95913189" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Contact",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

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
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1986, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "70246596", "Tapanez" });

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
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1993, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marcos", "46005110" });

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
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1980, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "16358656", "Fernandez" });

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
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(2008, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brayan", "32348740" });

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
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1978, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Juliet", "85917695", "Lee" });

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
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1995, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tedd", "26247413", "Doe" });

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
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1984, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brayan", "79600236", "Hernandez" });

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
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1981, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "33644355", "Lee" });

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
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2004, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brayan", "20206207", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1997, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tedd", "12309551", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "DateofBirth", "PhoneNumber" },
                values: new object[] { new DateTime(1955, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "33394848" });

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
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2006, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carlos", "54959378", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "DateofBirth", "PhoneNumber" },
                values: new object[] { new DateTime(2001, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "88613262" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1948, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marcos", "52037024", "Fernandez" });

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
                columns: new[] { "DateofBirth", "PhoneNumber" },
                values: new object[] { new DateTime(1961, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "84821567" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1987, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brayan", "13297615", "Hernandez" });

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
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1957, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jhon", "89143212" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1960, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jhon", "83691131" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "DateofBirth", "PhoneNumber" },
                values: new object[] { new DateTime(1980, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "83512003" });

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
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1944, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Miguel", "94423452" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1946, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "34922501", "Doe" });

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
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1956, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marcos", "75866473" });
        }
    }
}
