using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BankTest.Migrations
{
    public partial class ww : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1996, 6, 4, 10, 6, 42, 10, DateTimeKind.Local).AddTicks(327), "Tedd", "img_avatar3.png", "87143302", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1949, 6, 4, 10, 6, 42, 15, DateTimeKind.Local).AddTicks(9754), "Miguel", "img_avatar2.png", "79188471" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1969, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(250), "Marcos", "img_avatar2.png", "88359194", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1965, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(288), "Marcos", "img_avatar2.png", "24751258", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1955, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(306), "Marcos", "img_avatar1.png", "26409847", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1960, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(331), "Juliet", "img_avatar1.png", "45550980", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1966, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(350), "Tedd", "img_avatar4.png", "70401777" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2009, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(366), "Jhon", "img_avatar2.png", "11470498", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1982, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(383), "Brayan", "img_avatar3.png", "87617331", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1954, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(401), "Marcos", "img_avatar5.png", "41614580" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1983, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(419), "Brayan", "img_avatar5.png", "18577497", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2009, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(437), "Juliet", "img_avatar4.png", "74815191", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1976, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(453), "Miguel", "img_avatar5.png", "77797650", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1946, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(553), "Tedd", "img_avatar2.png", "28558140", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1966, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(571), "Juliet", "img_avatar1.png", "83362408", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1946, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(589), "Brayan", "img_avatar2.png", "69334976", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1984, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(605), "Tedd", "img_avatar5.png", "61252753", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateofBirth", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1973, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(624), "img_avatar4.png", "81655807", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1989, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(640), "Juliet", "img_avatar4.png", "41652387" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1965, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(657), "Brayan", "img_avatar1.png", "92253772", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1969, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(673), "Juliet", "img_avatar5.png", "19960049", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1970, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(689), "Marcos", "img_avatar4.png", "12553848", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1985, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(1054), "Juliet", "img_avatar2.png", "48140896", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1946, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(1089), "Tedd", "img_avatar4.png", "90083308", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2001, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(1109), "Tedd", "img_avatar2.png", "53318801", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "DateofBirth", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1991, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(1127), "img_avatar5.png", "15832276", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2010, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(1293), "Brayan", "img_avatar2.png", "56874871", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1992, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(1369), "Juliet", "img_avatar1.png", "68442413", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1975, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(1463), "Miguel", "img_avatar4.png", "24393596" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "DateofBirth", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1949, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(1483), "img_avatar3.png", "19277079", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1957, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(1500), "Miguel", "img_avatar4.png", "24509832", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2003, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(1517), "Miguel", "img_avatar5.png", "79840141", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1975, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(1534), "Marcos", "img_avatar2.png", "25168177", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1952, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(1557), "Miguel", "img_avatar2.png", "16601644", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1992, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(1574), "Miguel", "img_avatar1.png", "86679889" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2012, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(1592), "Jhon", "img_avatar4.png", "72810390", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1998, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(1609), "Carlos", "img_avatar2.png", "68477010" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1951, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(1627), "Brayan", "img_avatar4.png", "81489983", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1976, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(1644), "Miguel", "img_avatar2.png", "75720262" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1987, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(1661), "Tedd", "img_avatar1.png", "79275327", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "DateofBirth", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1954, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(1678), "img_avatar4.png", "80034629", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1947, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(1694), "Brayan", "img_avatar4.png", "15029072", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1981, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(1711), "Marcos", "img_avatar3.png", "23546348" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1950, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(1784), "Marcos", "img_avatar1.png", "90146076", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2007, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(1801), "Jhon", "img_avatar4.png", "40578170", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "DateofBirth", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1973, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(1818), "img_avatar4.png", "67878819", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "DateofBirth", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1996, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(1919), "img_avatar1.png", "58668333", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1983, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(1943), "Marcos", "img_avatar1.png", "93664692", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1955, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(1961), "Carlos", "img_avatar5.png", "20039311", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1987, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(1977), "Brayan", "img_avatar3.png", "36601094", "Doe" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1989, 6, 3, 20, 50, 56, 581, DateTimeKind.Local).AddTicks(2417), "Brayan", "avatar.png", "38338907", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1994, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(114), "Carlos", "avatar.png", "39477243" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2009, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(517), "Jhon", "avatar.png", "84816034", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1976, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(555), "Brayan", "avatar.png", "55684259", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2000, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(575), "Carlos", "avatar.png", "50127479", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1985, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(599), "Marcos", "avatar.png", "35581955", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1994, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(617), "Juliet", "avatar.png", "69918953" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1987, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(635), "Brayan", "avatar.png", "57394351", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1945, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(651), "Jhon", "avatar.png", "39159673", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1990, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(671), "Carlos", "avatar.png", "27745902" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1953, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(688), "Tedd", "avatar.png", "63882123", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1969, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(705), "Carlos", "avatar.png", "51134272", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1982, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(722), "Marcos", "avatar.png", "30526837", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1998, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(738), "Jhon", "avatar.png", "86042836", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1983, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(755), "Jhon", "avatar.png", "16691715", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2006, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(865), "Miguel", "avatar.png", "72343579", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1957, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(883), "Miguel", "avatar.png", "79706506", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateofBirth", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1945, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(902), "avatar.png", "10503454", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(2006, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(920), "Miguel", "avatar.png", "18437534" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1955, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(937), "Carlos", "avatar.png", "15682837", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1950, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(954), "Marcos", "avatar.png", "94090608", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1981, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(970), "Juliet", "avatar.png", "86520120", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1991, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(988), "Brayan", "avatar.png", "53808871", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1970, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1004), "Jhon", "avatar.png", "78086288", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1943, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1021), "Miguel", "avatar.png", "94622426", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "DateofBirth", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1992, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1037), "avatar.png", "62107499", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1975, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1054), "Tedd", "avatar.png", "18921810", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1993, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1070), "Jhon", "avatar.png", "30116577", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1991, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1086), "Brayan", "avatar.png", "80621935" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "DateofBirth", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1957, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1102), "avatar.png", "52272266", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1972, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1340), "Jhon", "avatar.png", "13363287", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1949, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1360), "Juliet", "avatar.png", "50406199", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1981, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1377), "Tedd", "avatar.png", "45699317", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2011, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1396), "Marcos", "avatar.png", "93736304", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1970, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1414), "Carlos", "avatar.png", "52286712" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1960, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1430), "Miguel", "avatar.png", "17718112", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1995, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1447), "Marcos", "avatar.png", "76808528" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2009, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1464), "Juliet", "avatar.png", "52820238", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1952, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1480), "Tedd", "avatar.png", "19018480" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1964, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1497), "Brayan", "avatar.png", "85988238", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "DateofBirth", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1961, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1513), "avatar.png", "78979622", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1983, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1530), "Miguel", "avatar.png", "41819648", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1993, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1546), "Tedd", "avatar.png", "45159569" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1952, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1562), "Carlos", "avatar.png", "74986689", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1999, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1579), "Brayan", "avatar.png", "82022368", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "DateofBirth", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1977, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1651), "avatar.png", "58278318", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "DateofBirth", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2011, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1668), "avatar.png", "35643399", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1966, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1685), "Jhon", "avatar.png", "32576276", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1947, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1701), "Miguel", "avatar.png", "56759310", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1983, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1718), "Miguel", "avatar.png", "95913189", "Tapanez" });
        }
    }
}
