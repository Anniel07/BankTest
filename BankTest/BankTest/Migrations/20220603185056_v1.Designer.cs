﻿// <auto-generated />
using System;
using BankTest.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BankTest.Migrations
{
    [DbContext(typeof(BankTestContext))]
    [Migration("20220603185056_v1")]
    partial class v1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BankTest.Models.Contact", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Addresses")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateofBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("PersonalPhoto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Contact");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Addresses = "Some Adress 0",
                            DateofBirth = new DateTime(1989, 6, 3, 20, 50, 56, 581, DateTimeKind.Local).AddTicks(2417),
                            FirstName = "Brayan",
                            PersonalPhoto = "avatar.png",
                            PhoneNumber = "38338907",
                            SecondName = "Fernandez"
                        },
                        new
                        {
                            ID = 2,
                            Addresses = "Some Adress 1",
                            DateofBirth = new DateTime(1994, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(114),
                            FirstName = "Carlos",
                            PersonalPhoto = "avatar.png",
                            PhoneNumber = "39477243",
                            SecondName = "Lee"
                        },
                        new
                        {
                            ID = 3,
                            Addresses = "Some Adress 2",
                            DateofBirth = new DateTime(2009, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(517),
                            FirstName = "Jhon",
                            PersonalPhoto = "avatar.png",
                            PhoneNumber = "84816034",
                            SecondName = "Tapanez"
                        },
                        new
                        {
                            ID = 4,
                            Addresses = "Some Adress 3",
                            DateofBirth = new DateTime(1976, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(555),
                            FirstName = "Brayan",
                            PersonalPhoto = "avatar.png",
                            PhoneNumber = "55684259",
                            SecondName = "Doe"
                        },
                        new
                        {
                            ID = 5,
                            Addresses = "Some Adress 4",
                            DateofBirth = new DateTime(2000, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(575),
                            FirstName = "Carlos",
                            PersonalPhoto = "avatar.png",
                            PhoneNumber = "50127479",
                            SecondName = "Doe"
                        },
                        new
                        {
                            ID = 6,
                            Addresses = "Some Adress 5",
                            DateofBirth = new DateTime(1985, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(599),
                            FirstName = "Marcos",
                            PersonalPhoto = "avatar.png",
                            PhoneNumber = "35581955",
                            SecondName = "Fernandez"
                        },
                        new
                        {
                            ID = 7,
                            Addresses = "Some Adress 6",
                            DateofBirth = new DateTime(1994, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(617),
                            FirstName = "Juliet",
                            PersonalPhoto = "avatar.png",
                            PhoneNumber = "69918953",
                            SecondName = "Fernandez"
                        },
                        new
                        {
                            ID = 8,
                            Addresses = "Some Adress 7",
                            DateofBirth = new DateTime(1987, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(635),
                            FirstName = "Brayan",
                            PersonalPhoto = "avatar.png",
                            PhoneNumber = "57394351",
                            SecondName = "Fernandez"
                        },
                        new
                        {
                            ID = 9,
                            Addresses = "Some Adress 8",
                            DateofBirth = new DateTime(1945, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(651),
                            FirstName = "Jhon",
                            PersonalPhoto = "avatar.png",
                            PhoneNumber = "39159673",
                            SecondName = "Fernandez"
                        },
                        new
                        {
                            ID = 10,
                            Addresses = "Some Adress 9",
                            DateofBirth = new DateTime(1990, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(671),
                            FirstName = "Carlos",
                            PersonalPhoto = "avatar.png",
                            PhoneNumber = "27745902",
                            SecondName = "Garcia"
                        },
                        new
                        {
                            ID = 11,
                            Addresses = "Some Adress 10",
                            DateofBirth = new DateTime(1953, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(688),
                            FirstName = "Tedd",
                            PersonalPhoto = "avatar.png",
                            PhoneNumber = "63882123",
                            SecondName = "Lee"
                        },
                        new
                        {
                            ID = 12,
                            Addresses = "Some Adress 11",
                            DateofBirth = new DateTime(1969, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(705),
                            FirstName = "Carlos",
                            PersonalPhoto = "avatar.png",
                            PhoneNumber = "51134272",
                            SecondName = "Lee"
                        },
                        new
                        {
                            ID = 13,
                            Addresses = "Some Adress 12",
                            DateofBirth = new DateTime(1982, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(722),
                            FirstName = "Marcos",
                            PersonalPhoto = "avatar.png",
                            PhoneNumber = "30526837",
                            SecondName = "Fernandez"
                        },
                        new
                        {
                            ID = 14,
                            Addresses = "Some Adress 13",
                            DateofBirth = new DateTime(1998, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(738),
                            FirstName = "Jhon",
                            PersonalPhoto = "avatar.png",
                            PhoneNumber = "86042836",
                            SecondName = "Hernandez"
                        },
                        new
                        {
                            ID = 15,
                            Addresses = "Some Adress 14",
                            DateofBirth = new DateTime(1983, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(755),
                            FirstName = "Jhon",
                            PersonalPhoto = "avatar.png",
                            PhoneNumber = "16691715",
                            SecondName = "Doe"
                        },
                        new
                        {
                            ID = 16,
                            Addresses = "Some Adress 15",
                            DateofBirth = new DateTime(2006, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(865),
                            FirstName = "Miguel",
                            PersonalPhoto = "avatar.png",
                            PhoneNumber = "72343579",
                            SecondName = "Stampton"
                        },
                        new
                        {
                            ID = 17,
                            Addresses = "Some Adress 16",
                            DateofBirth = new DateTime(1957, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(883),
                            FirstName = "Miguel",
                            PersonalPhoto = "avatar.png",
                            PhoneNumber = "79706506",
                            SecondName = "Garcia"
                        },
                        new
                        {
                            ID = 18,
                            Addresses = "Some Adress 17",
                            DateofBirth = new DateTime(1945, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(902),
                            FirstName = "Brayan",
                            PersonalPhoto = "avatar.png",
                            PhoneNumber = "10503454",
                            SecondName = "Hernandez"
                        },
                        new
                        {
                            ID = 19,
                            Addresses = "Some Adress 18",
                            DateofBirth = new DateTime(2006, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(920),
                            FirstName = "Miguel",
                            PersonalPhoto = "avatar.png",
                            PhoneNumber = "18437534",
                            SecondName = "Tapanez"
                        },
                        new
                        {
                            ID = 20,
                            Addresses = "Some Adress 19",
                            DateofBirth = new DateTime(1955, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(937),
                            FirstName = "Carlos",
                            PersonalPhoto = "avatar.png",
                            PhoneNumber = "15682837",
                            SecondName = "Lee"
                        },
                        new
                        {
                            ID = 21,
                            Addresses = "Some Adress 20",
                            DateofBirth = new DateTime(1950, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(954),
                            FirstName = "Marcos",
                            PersonalPhoto = "avatar.png",
                            PhoneNumber = "94090608",
                            SecondName = "Lee"
                        },
                        new
                        {
                            ID = 22,
                            Addresses = "Some Adress 21",
                            DateofBirth = new DateTime(1981, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(970),
                            FirstName = "Juliet",
                            PersonalPhoto = "avatar.png",
                            PhoneNumber = "86520120",
                            SecondName = "Doe"
                        },
                        new
                        {
                            ID = 23,
                            Addresses = "Some Adress 22",
                            DateofBirth = new DateTime(1991, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(988),
                            FirstName = "Brayan",
                            PersonalPhoto = "avatar.png",
                            PhoneNumber = "53808871",
                            SecondName = "Doe"
                        },
                        new
                        {
                            ID = 24,
                            Addresses = "Some Adress 23",
                            DateofBirth = new DateTime(1970, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1004),
                            FirstName = "Jhon",
                            PersonalPhoto = "avatar.png",
                            PhoneNumber = "78086288",
                            SecondName = "Hernandez"
                        },
                        new
                        {
                            ID = 25,
                            Addresses = "Some Adress 24",
                            DateofBirth = new DateTime(1943, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1021),
                            FirstName = "Miguel",
                            PersonalPhoto = "avatar.png",
                            PhoneNumber = "94622426",
                            SecondName = "Hernandez"
                        },
                        new
                        {
                            ID = 26,
                            Addresses = "Some Adress 25",
                            DateofBirth = new DateTime(1992, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1037),
                            FirstName = "Jhon",
                            PersonalPhoto = "avatar.png",
                            PhoneNumber = "62107499",
                            SecondName = "Lee"
                        },
                        new
                        {
                            ID = 27,
                            Addresses = "Some Adress 26",
                            DateofBirth = new DateTime(1975, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1054),
                            FirstName = "Tedd",
                            PersonalPhoto = "avatar.png",
                            PhoneNumber = "18921810",
                            SecondName = "Garcia"
                        },
                        new
                        {
                            ID = 28,
                            Addresses = "Some Adress 27",
                            DateofBirth = new DateTime(1993, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1070),
                            FirstName = "Jhon",
                            PersonalPhoto = "avatar.png",
                            PhoneNumber = "30116577",
                            SecondName = "Doe"
                        },
                        new
                        {
                            ID = 29,
                            Addresses = "Some Adress 28",
                            DateofBirth = new DateTime(1991, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1086),
                            FirstName = "Brayan",
                            PersonalPhoto = "avatar.png",
                            PhoneNumber = "80621935",
                            SecondName = "Fernandez"
                        },
                        new
                        {
                            ID = 30,
                            Addresses = "Some Adress 29",
                            DateofBirth = new DateTime(1957, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1102),
                            FirstName = "Miguel",
                            PersonalPhoto = "avatar.png",
                            PhoneNumber = "52272266",
                            SecondName = "Hernandez"
                        },
                        new
                        {
                            ID = 31,
                            Addresses = "Some Adress 30",
                            DateofBirth = new DateTime(1972, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1340),
                            FirstName = "Jhon",
                            PersonalPhoto = "avatar.png",
                            PhoneNumber = "13363287",
                            SecondName = "Tapanez"
                        },
                        new
                        {
                            ID = 32,
                            Addresses = "Some Adress 31",
                            DateofBirth = new DateTime(1949, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1360),
                            FirstName = "Juliet",
                            PersonalPhoto = "avatar.png",
                            PhoneNumber = "50406199",
                            SecondName = "Garcia"
                        },
                        new
                        {
                            ID = 33,
                            Addresses = "Some Adress 32",
                            DateofBirth = new DateTime(1981, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1377),
                            FirstName = "Tedd",
                            PersonalPhoto = "avatar.png",
                            PhoneNumber = "45699317",
                            SecondName = "Fernandez"
                        },
                        new
                        {
                            ID = 34,
                            Addresses = "Some Adress 33",
                            DateofBirth = new DateTime(2011, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1396),
                            FirstName = "Marcos",
                            PersonalPhoto = "avatar.png",
                            PhoneNumber = "93736304",
                            SecondName = "Tapanez"
                        },
                        new
                        {
                            ID = 35,
                            Addresses = "Some Adress 34",
                            DateofBirth = new DateTime(1970, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1414),
                            FirstName = "Carlos",
                            PersonalPhoto = "avatar.png",
                            PhoneNumber = "52286712",
                            SecondName = "Fernandez"
                        },
                        new
                        {
                            ID = 36,
                            Addresses = "Some Adress 35",
                            DateofBirth = new DateTime(1960, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1430),
                            FirstName = "Miguel",
                            PersonalPhoto = "avatar.png",
                            PhoneNumber = "17718112",
                            SecondName = "Fernandez"
                        },
                        new
                        {
                            ID = 37,
                            Addresses = "Some Adress 36",
                            DateofBirth = new DateTime(1995, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1447),
                            FirstName = "Marcos",
                            PersonalPhoto = "avatar.png",
                            PhoneNumber = "76808528",
                            SecondName = "Doe"
                        },
                        new
                        {
                            ID = 38,
                            Addresses = "Some Adress 37",
                            DateofBirth = new DateTime(2009, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1464),
                            FirstName = "Juliet",
                            PersonalPhoto = "avatar.png",
                            PhoneNumber = "52820238",
                            SecondName = "Lee"
                        },
                        new
                        {
                            ID = 39,
                            Addresses = "Some Adress 38",
                            DateofBirth = new DateTime(1952, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1480),
                            FirstName = "Tedd",
                            PersonalPhoto = "avatar.png",
                            PhoneNumber = "19018480",
                            SecondName = "Garcia"
                        },
                        new
                        {
                            ID = 40,
                            Addresses = "Some Adress 39",
                            DateofBirth = new DateTime(1964, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1497),
                            FirstName = "Brayan",
                            PersonalPhoto = "avatar.png",
                            PhoneNumber = "85988238",
                            SecondName = "Hernandez"
                        },
                        new
                        {
                            ID = 41,
                            Addresses = "Some Adress 40",
                            DateofBirth = new DateTime(1961, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1513),
                            FirstName = "Carlos",
                            PersonalPhoto = "avatar.png",
                            PhoneNumber = "78979622",
                            SecondName = "Doe"
                        },
                        new
                        {
                            ID = 42,
                            Addresses = "Some Adress 41",
                            DateofBirth = new DateTime(1983, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1530),
                            FirstName = "Miguel",
                            PersonalPhoto = "avatar.png",
                            PhoneNumber = "41819648",
                            SecondName = "Tapanez"
                        },
                        new
                        {
                            ID = 43,
                            Addresses = "Some Adress 42",
                            DateofBirth = new DateTime(1993, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1546),
                            FirstName = "Tedd",
                            PersonalPhoto = "avatar.png",
                            PhoneNumber = "45159569",
                            SecondName = "Fernandez"
                        },
                        new
                        {
                            ID = 44,
                            Addresses = "Some Adress 43",
                            DateofBirth = new DateTime(1952, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1562),
                            FirstName = "Carlos",
                            PersonalPhoto = "avatar.png",
                            PhoneNumber = "74986689",
                            SecondName = "Fernandez"
                        },
                        new
                        {
                            ID = 45,
                            Addresses = "Some Adress 44",
                            DateofBirth = new DateTime(1999, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1579),
                            FirstName = "Brayan",
                            PersonalPhoto = "avatar.png",
                            PhoneNumber = "82022368",
                            SecondName = "Garcia"
                        },
                        new
                        {
                            ID = 46,
                            Addresses = "Some Adress 45",
                            DateofBirth = new DateTime(1977, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1651),
                            FirstName = "Brayan",
                            PersonalPhoto = "avatar.png",
                            PhoneNumber = "58278318",
                            SecondName = "Hernandez"
                        },
                        new
                        {
                            ID = 47,
                            Addresses = "Some Adress 46",
                            DateofBirth = new DateTime(2011, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1668),
                            FirstName = "Brayan",
                            PersonalPhoto = "avatar.png",
                            PhoneNumber = "35643399",
                            SecondName = "Tapanez"
                        },
                        new
                        {
                            ID = 48,
                            Addresses = "Some Adress 47",
                            DateofBirth = new DateTime(1966, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1685),
                            FirstName = "Jhon",
                            PersonalPhoto = "avatar.png",
                            PhoneNumber = "32576276",
                            SecondName = "Tapanez"
                        },
                        new
                        {
                            ID = 49,
                            Addresses = "Some Adress 48",
                            DateofBirth = new DateTime(1947, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1701),
                            FirstName = "Miguel",
                            PersonalPhoto = "avatar.png",
                            PhoneNumber = "56759310",
                            SecondName = "Lee"
                        },
                        new
                        {
                            ID = 50,
                            Addresses = "Some Adress 49",
                            DateofBirth = new DateTime(1983, 6, 3, 20, 50, 56, 586, DateTimeKind.Local).AddTicks(1718),
                            FirstName = "Miguel",
                            PersonalPhoto = "avatar.png",
                            PhoneNumber = "95913189",
                            SecondName = "Tapanez"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
