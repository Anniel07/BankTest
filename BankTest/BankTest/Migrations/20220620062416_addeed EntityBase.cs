using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BankTest.Migrations
{
    public partial class addeedEntityBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2005, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(6549), "60809378", "Hernandez" });

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
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2007, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7096), "Marcos", "img_avatar1.png", "48153440", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1956, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7122), "96883936", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1992, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7149), "Brayan", "58535167", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1976, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7170), "Jhon", "90329650" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2005, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7190), "Miguel", "20758542", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateofBirth", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1975, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7210), "img_avatar4.png", "14173980", "Tapanez" });

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
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2010, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7251), "Tedd", "51359263", "Tapanez" });

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
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1973, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7292), "Marcos", "img_avatar2.png", "59516514", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(2008, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7311), "Juliet", "img_avatar3.png", "95418698" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateofBirth", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1945, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7330), "img_avatar1.png", "76030078", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1959, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7526), "Miguel", "img_avatar4.png", "39923151", "Stampton" });

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
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1997, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7598), "Juliet", "img_avatar5.png", "23427955", "Fernandez" });

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
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2004, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7637), "Marcos", "img_avatar4.png", "42543858", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1991, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7656), "Miguel", "img_avatar3.png", "40249616", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1992, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7676), "Carlos", "img_avatar4.png", "29664430", "Doe" });

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
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1991, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7714), "Juliet", "img_avatar4.png", "35509647", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1955, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7734), "Carlos", "img_avatar1.png", "89370274" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2008, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7753), "Tedd", "img_avatar5.png", "67723344", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1944, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7773), "Carlos", "img_avatar1.png", "46918609", "Stampton" });

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
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2012, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7812), "Marcos", "img_avatar4.png", "58045492", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2002, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7884), "Tedd", "img_avatar5.png", "60033298", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1954, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7906), "Miguel", "img_avatar1.png", "66951804", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1983, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7926), "Jhon", "24779799" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1966, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7948), "Marcos", "img_avatar1.png", "43422660", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "DateofBirth", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2004, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(7998), "img_avatar5.png", "73324967", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2007, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(8018), "Jhon", "14917481", "Fernandez" });

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
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1977, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(8057), "Carlos", "84595192", "Garcia" });

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
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1968, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(8115), "Marcos", "53242922", "Fernandez" });

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
                columns: new[] { "DateofBirth", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1991, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(8173), "img_avatar4.png", "39457789", "Lee" });

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
                columns: new[] { "DateofBirth", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1958, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(8263), "img_avatar3.png", "70220895", "Fernandez" });

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
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1956, 6, 20, 8, 24, 16, 510, DateTimeKind.Local).AddTicks(8303), "Brayan", "img_avatar1.png", "79215377", "Tapanez" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1986, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4344), "53493277", "Fernandez" });

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
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(2004, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4605), "Carlos", "img_avatar3.png", "96570026", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateofBirth", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1966, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4624), "25772747", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1967, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4645), "Miguel", "52770248", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1955, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4664), "Marcos", "53958282" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1953, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4680), "Marcos", "92516426", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateofBirth", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1972, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4760), "img_avatar5.png", "84730732", "Stampton" });

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
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1968, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4796), "Miguel", "86959833", "Fernandez" });

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
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1949, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4830), "Tedd", "img_avatar4.png", "45621266", "Lee" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(2005, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4846), "Marcos", "img_avatar2.png", "39342210" });

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
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1954, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4928), "Carlos", "img_avatar2.png", "21104236", "Tapanez" });

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
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1992, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4993), "Brayan", "img_avatar5.png", "70011474", "Garcia" });

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
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1963, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5069), "Carlos", "img_avatar5.png", "94508817", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(2007, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5085), "Jhon", "img_avatar2.png", "90287950" });

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
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1967, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5132), "Brayan", "20633372", "Tapanez" });

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
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(1977, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5197), "Marcos", "11476456" });

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
                columns: new[] { "DateofBirth", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1953, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5232), "img_avatar1.png", "72737688", "Doe" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1971, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5248), "Carlos", "76401054", "Garcia" });

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
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1961, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5280), "Marcos", "59378092", "Lee" });

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
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1968, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5439), "Jhon", "img_avatar1.png", "91740062", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "DateofBirth", "FirstName", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1971, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5455), "Brayan", "54076713", "Garcia" });

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
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber" },
                values: new object[] { new DateTime(1991, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5489), "Carlos", "img_avatar4.png", "50132924" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "DateofBirth", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1976, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5505), "img_avatar3.png", "25738739", "Hernandez" });

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
                columns: new[] { "DateofBirth", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1995, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5537), "img_avatar1.png", "41031395", "Lee" });

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
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1950, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5585), "Brayan", "img_avatar3.png", "45525049", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "DateofBirth", "FirstName", "PersonalPhoto", "PhoneNumber", "SecondName" },
                values: new object[] { new DateTime(1951, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5602), "Juliet", "img_avatar4.png", "96044041", "Stampton" });
        }
    }
}
