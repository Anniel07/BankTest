using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BankTest.Migrations
{
    public partial class ww1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2011, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2056), "Juliet", "img_avatar3.png", "15834745", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1980, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2084), "Juliet", "40010584" });

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
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1991, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2130), "Miguel", "img_avatar5.png", "62331062", "Doe" });

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
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1951, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2168), "Miguel", "img_avatar1.png", "46105097" });

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
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1962, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2225), "Brayan", "img_avatar1.png", "29195358" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2004, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2243), "Tedd", "22936505", "Garcia" });

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
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1999, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2334), "Juliet", "11717788", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1952, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2352), "Carlos", "img_avatar3.png", "82709174", "Fernandez" });

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
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1983, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2473), "Miguel", "img_avatar5.png", "69921246", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "DateofBirth", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1979, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2490), "img_avatar1.png", "54549260", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1969, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2508), "Carlos", "img_avatar4.png", "91620321" });

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
                columns: new[] { "DateofBirth", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1973, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2544), "img_avatar3.png", "50308365", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1959, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2562), "Marcos", "img_avatar4.png", "45802447" });

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
                columns: new[] { "DateofBirth", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1980, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2635), "img_avatar4.png", "75248157", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1963, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2653), "Miguel", "img_avatar5.png", "63167578" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1944, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2716), "22022861", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "DateofBirth", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2006, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2738), "img_avatar4.png", "78102767", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "DateofBirth", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1969, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2755), "img_avatar1.png", "83577659", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1977, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2773), "Miguel", "img_avatar5.png", "38040136" });

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
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1990, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2826), "Jhon", "img_avatar3.png", "26214067" });

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
                columns: new[] { "DateofBirth", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1979, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2862), "img_avatar2.png", "80008898" });

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
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1985, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2897), "Miguel", "img_avatar3.png", "71277502", "Lee" });

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
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1985, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2932), "Carlos", "74530399", "Garcia" });

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
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1992, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(2985), "Miguel", "80211998", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1978, 6, 4, 10, 11, 50, 577, DateTimeKind.Local).AddTicks(3095), "Marcos", "img_avatar2.png", "61181391", "Garcia" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1949, 6, 4, 10, 6, 42, 15, DateTimeKind.Local).AddTicks(9754), "Miguel", "img_avatar2.png", "79188471", "Lee" });

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
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1955, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(306), "Marcos", "26409847" });

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
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1966, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(350), "Tedd", "img_avatar4.png", "70401777", "Fernandez" });

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
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1982, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(383), "Brayan", "img_avatar3.png", "87617331" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1954, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(401), "Marcos", "img_avatar5.png", "41614580", "Garcia" });

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
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(2009, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(437), "Juliet", "img_avatar4.png", "74815191" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1976, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(453), "Miguel", "77797650", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1946, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(553), "Tedd", "28558140", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateofBirth", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1966, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(571), "img_avatar1.png", "83362408", "Fernandez" });

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
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1973, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(624), "Brayan", "81655807", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1989, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(640), "Juliet", "img_avatar4.png", "41652387", "Tapanez" });

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
                columns: new[] { "DateofBirth", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1946, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(1089), "img_avatar4.png", "90083308", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(2001, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(1109), "Tedd", "img_avatar2.png", "53318801" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1991, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(1127), "Jhon", "img_avatar5.png", "15832276", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "DateofBirth", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2010, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(1293), "img_avatar2.png", "56874871", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1992, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(1369), "Juliet", "img_avatar1.png", "68442413" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1975, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(1463), "Miguel", "img_avatar4.png", "24393596", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1949, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(1483), "Miguel", "img_avatar3.png", "19277079", "Garcia" });

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
                columns: new[] { "DateofBirth", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2003, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(1517), "img_avatar5.png", "79840141", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1975, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(1534), "Marcos", "img_avatar2.png", "25168177" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1952, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(1557), "16601644", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "DateofBirth", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1992, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(1574), "img_avatar1.png", "86679889", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "DateofBirth", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2012, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(1592), "img_avatar4.png", "72810390", "Lee" });

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
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1976, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(1644), "Miguel", "img_avatar2.png", "75720262", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1987, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(1661), "Tedd", "img_avatar1.png", "79275327" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1954, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(1678), "Carlos", "img_avatar4.png", "80034629", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "DateofBirth", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1947, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(1694), "img_avatar4.png", "15029072" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1981, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(1711), "Marcos", "img_avatar3.png", "23546348", "Fernandez" });

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
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1973, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(1818), "Brayan", "67878819", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1996, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(1919), "Brayan", "img_avatar1.png", "58668333", "Fernandez" });

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
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1955, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(1961), "Carlos", "20039311", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1987, 6, 4, 10, 6, 42, 16, DateTimeKind.Local).AddTicks(1977), "Brayan", "img_avatar3.png", "36601094", "Doe" });
        }
    }
}
