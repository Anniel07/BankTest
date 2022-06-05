﻿// <auto-generated />
using System;
using BankTest.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BankTest.Migrations
{
    [DbContext(typeof(BankTestContext))]
    partial class BankTestContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            DateofBirth = new DateTime(1963, 6, 4, 10, 12, 40, 525, DateTimeKind.Local).AddTicks(8311),
                            FirstName = "Brayan",
                            PersonalPhoto = "img_avatar3.png",
                            PhoneNumber = "81359605",
                            SecondName = "Tapanez"
                        },
                        new
                        {
                            ID = 2,
                            Addresses = "Some Adress 1",
                            DateofBirth = new DateTime(1986, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4344),
                            FirstName = "Miguel",
                            PersonalPhoto = "img_avatar3.png",
                            PhoneNumber = "53493277",
                            SecondName = "Fernandez"
                        },
                        new
                        {
                            ID = 3,
                            Addresses = "Some Adress 2",
                            DateofBirth = new DateTime(1971, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4570),
                            FirstName = "Juliet",
                            PersonalPhoto = "img_avatar1.png",
                            PhoneNumber = "19970092",
                            SecondName = "Doe"
                        },
                        new
                        {
                            ID = 4,
                            Addresses = "Some Adress 3",
                            DateofBirth = new DateTime(2004, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4605),
                            FirstName = "Carlos",
                            PersonalPhoto = "img_avatar3.png",
                            PhoneNumber = "96570026",
                            SecondName = "Doe"
                        },
                        new
                        {
                            ID = 5,
                            Addresses = "Some Adress 4",
                            DateofBirth = new DateTime(1966, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4624),
                            FirstName = "Carlos",
                            PersonalPhoto = "img_avatar4.png",
                            PhoneNumber = "25772747",
                            SecondName = "Lee"
                        },
                        new
                        {
                            ID = 6,
                            Addresses = "Some Adress 5",
                            DateofBirth = new DateTime(1967, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4645),
                            FirstName = "Miguel",
                            PersonalPhoto = "img_avatar1.png",
                            PhoneNumber = "52770248",
                            SecondName = "Hernandez"
                        },
                        new
                        {
                            ID = 7,
                            Addresses = "Some Adress 6",
                            DateofBirth = new DateTime(1955, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4664),
                            FirstName = "Marcos",
                            PersonalPhoto = "img_avatar4.png",
                            PhoneNumber = "53958282",
                            SecondName = "Doe"
                        },
                        new
                        {
                            ID = 8,
                            Addresses = "Some Adress 7",
                            DateofBirth = new DateTime(1953, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4680),
                            FirstName = "Marcos",
                            PersonalPhoto = "img_avatar4.png",
                            PhoneNumber = "92516426",
                            SecondName = "Garcia"
                        },
                        new
                        {
                            ID = 9,
                            Addresses = "Some Adress 8",
                            DateofBirth = new DateTime(1972, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4760),
                            FirstName = "Juliet",
                            PersonalPhoto = "img_avatar5.png",
                            PhoneNumber = "84730732",
                            SecondName = "Stampton"
                        },
                        new
                        {
                            ID = 10,
                            Addresses = "Some Adress 9",
                            DateofBirth = new DateTime(1991, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4780),
                            FirstName = "Carlos",
                            PersonalPhoto = "img_avatar5.png",
                            PhoneNumber = "69754816",
                            SecondName = "Lee"
                        },
                        new
                        {
                            ID = 11,
                            Addresses = "Some Adress 10",
                            DateofBirth = new DateTime(1968, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4796),
                            FirstName = "Miguel",
                            PersonalPhoto = "img_avatar1.png",
                            PhoneNumber = "86959833",
                            SecondName = "Fernandez"
                        },
                        new
                        {
                            ID = 12,
                            Addresses = "Some Adress 11",
                            DateofBirth = new DateTime(1975, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4814),
                            FirstName = "Tedd",
                            PersonalPhoto = "img_avatar4.png",
                            PhoneNumber = "10321450",
                            SecondName = "Fernandez"
                        },
                        new
                        {
                            ID = 13,
                            Addresses = "Some Adress 12",
                            DateofBirth = new DateTime(1949, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4830),
                            FirstName = "Tedd",
                            PersonalPhoto = "img_avatar4.png",
                            PhoneNumber = "45621266",
                            SecondName = "Lee"
                        },
                        new
                        {
                            ID = 14,
                            Addresses = "Some Adress 13",
                            DateofBirth = new DateTime(2005, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4846),
                            FirstName = "Marcos",
                            PersonalPhoto = "img_avatar2.png",
                            PhoneNumber = "39342210",
                            SecondName = "Hernandez"
                        },
                        new
                        {
                            ID = 15,
                            Addresses = "Some Adress 14",
                            DateofBirth = new DateTime(1998, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4862),
                            FirstName = "Juliet",
                            PersonalPhoto = "img_avatar3.png",
                            PhoneNumber = "31873366",
                            SecondName = "Fernandez"
                        },
                        new
                        {
                            ID = 16,
                            Addresses = "Some Adress 15",
                            DateofBirth = new DateTime(1954, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4878),
                            FirstName = "Marcos",
                            PersonalPhoto = "img_avatar2.png",
                            PhoneNumber = "31862972",
                            SecondName = "Hernandez"
                        },
                        new
                        {
                            ID = 17,
                            Addresses = "Some Adress 16",
                            DateofBirth = new DateTime(1943, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4894),
                            FirstName = "Juliet",
                            PersonalPhoto = "img_avatar3.png",
                            PhoneNumber = "56475357",
                            SecondName = "Tapanez"
                        },
                        new
                        {
                            ID = 18,
                            Addresses = "Some Adress 17",
                            DateofBirth = new DateTime(1944, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4911),
                            FirstName = "Tedd",
                            PersonalPhoto = "img_avatar2.png",
                            PhoneNumber = "45763964",
                            SecondName = "Fernandez"
                        },
                        new
                        {
                            ID = 19,
                            Addresses = "Some Adress 18",
                            DateofBirth = new DateTime(1954, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4928),
                            FirstName = "Carlos",
                            PersonalPhoto = "img_avatar2.png",
                            PhoneNumber = "21104236",
                            SecondName = "Tapanez"
                        },
                        new
                        {
                            ID = 20,
                            Addresses = "Some Adress 19",
                            DateofBirth = new DateTime(2000, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4944),
                            FirstName = "Brayan",
                            PersonalPhoto = "img_avatar1.png",
                            PhoneNumber = "25925944",
                            SecondName = "Lee"
                        },
                        new
                        {
                            ID = 21,
                            Addresses = "Some Adress 20",
                            DateofBirth = new DateTime(1943, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4961),
                            FirstName = "Brayan",
                            PersonalPhoto = "img_avatar5.png",
                            PhoneNumber = "36531459",
                            SecondName = "Stampton"
                        },
                        new
                        {
                            ID = 22,
                            Addresses = "Some Adress 21",
                            DateofBirth = new DateTime(1985, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4977),
                            FirstName = "Tedd",
                            PersonalPhoto = "img_avatar2.png",
                            PhoneNumber = "38754307",
                            SecondName = "Hernandez"
                        },
                        new
                        {
                            ID = 23,
                            Addresses = "Some Adress 22",
                            DateofBirth = new DateTime(1992, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(4993),
                            FirstName = "Brayan",
                            PersonalPhoto = "img_avatar5.png",
                            PhoneNumber = "70011474",
                            SecondName = "Garcia"
                        },
                        new
                        {
                            ID = 24,
                            Addresses = "Some Adress 23",
                            DateofBirth = new DateTime(1985, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5051),
                            FirstName = "Carlos",
                            PersonalPhoto = "img_avatar2.png",
                            PhoneNumber = "90765398",
                            SecondName = "Lee"
                        },
                        new
                        {
                            ID = 25,
                            Addresses = "Some Adress 24",
                            DateofBirth = new DateTime(1963, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5069),
                            FirstName = "Carlos",
                            PersonalPhoto = "img_avatar5.png",
                            PhoneNumber = "94508817",
                            SecondName = "Hernandez"
                        },
                        new
                        {
                            ID = 26,
                            Addresses = "Some Adress 25",
                            DateofBirth = new DateTime(2007, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5085),
                            FirstName = "Jhon",
                            PersonalPhoto = "img_avatar2.png",
                            PhoneNumber = "90287950",
                            SecondName = "Garcia"
                        },
                        new
                        {
                            ID = 27,
                            Addresses = "Some Adress 26",
                            DateofBirth = new DateTime(1966, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5101),
                            FirstName = "Jhon",
                            PersonalPhoto = "img_avatar1.png",
                            PhoneNumber = "24932982",
                            SecondName = "Doe"
                        },
                        new
                        {
                            ID = 28,
                            Addresses = "Some Adress 27",
                            DateofBirth = new DateTime(1964, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5117),
                            FirstName = "Brayan",
                            PersonalPhoto = "img_avatar2.png",
                            PhoneNumber = "59038455",
                            SecondName = "Tapanez"
                        },
                        new
                        {
                            ID = 29,
                            Addresses = "Some Adress 28",
                            DateofBirth = new DateTime(1967, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5132),
                            FirstName = "Brayan",
                            PersonalPhoto = "img_avatar2.png",
                            PhoneNumber = "20633372",
                            SecondName = "Tapanez"
                        },
                        new
                        {
                            ID = 30,
                            Addresses = "Some Adress 29",
                            DateofBirth = new DateTime(2000, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5149),
                            FirstName = "Juliet",
                            PersonalPhoto = "img_avatar5.png",
                            PhoneNumber = "27713059",
                            SecondName = "Stampton"
                        },
                        new
                        {
                            ID = 31,
                            Addresses = "Some Adress 30",
                            DateofBirth = new DateTime(1993, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5165),
                            FirstName = "Carlos",
                            PersonalPhoto = "img_avatar4.png",
                            PhoneNumber = "92973246",
                            SecondName = "Fernandez"
                        },
                        new
                        {
                            ID = 32,
                            Addresses = "Some Adress 31",
                            DateofBirth = new DateTime(2009, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5181),
                            FirstName = "Jhon",
                            PersonalPhoto = "img_avatar5.png",
                            PhoneNumber = "43596121",
                            SecondName = "Tapanez"
                        },
                        new
                        {
                            ID = 33,
                            Addresses = "Some Adress 32",
                            DateofBirth = new DateTime(1977, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5197),
                            FirstName = "Marcos",
                            PersonalPhoto = "img_avatar2.png",
                            PhoneNumber = "11476456",
                            SecondName = "Doe"
                        },
                        new
                        {
                            ID = 34,
                            Addresses = "Some Adress 33",
                            DateofBirth = new DateTime(2004, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5215),
                            FirstName = "Brayan",
                            PersonalPhoto = "img_avatar4.png",
                            PhoneNumber = "62948382",
                            SecondName = "Lee"
                        },
                        new
                        {
                            ID = 35,
                            Addresses = "Some Adress 34",
                            DateofBirth = new DateTime(1953, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5232),
                            FirstName = "Carlos",
                            PersonalPhoto = "img_avatar1.png",
                            PhoneNumber = "72737688",
                            SecondName = "Doe"
                        },
                        new
                        {
                            ID = 36,
                            Addresses = "Some Adress 35",
                            DateofBirth = new DateTime(1971, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5248),
                            FirstName = "Carlos",
                            PersonalPhoto = "img_avatar5.png",
                            PhoneNumber = "76401054",
                            SecondName = "Garcia"
                        },
                        new
                        {
                            ID = 37,
                            Addresses = "Some Adress 36",
                            DateofBirth = new DateTime(1951, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5264),
                            FirstName = "Tedd",
                            PersonalPhoto = "img_avatar5.png",
                            PhoneNumber = "98994730",
                            SecondName = "Hernandez"
                        },
                        new
                        {
                            ID = 38,
                            Addresses = "Some Adress 37",
                            DateofBirth = new DateTime(1961, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5280),
                            FirstName = "Marcos",
                            PersonalPhoto = "img_avatar1.png",
                            PhoneNumber = "59378092",
                            SecondName = "Lee"
                        },
                        new
                        {
                            ID = 39,
                            Addresses = "Some Adress 38",
                            DateofBirth = new DateTime(1990, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5420),
                            FirstName = "Brayan",
                            PersonalPhoto = "img_avatar2.png",
                            PhoneNumber = "62795045",
                            SecondName = "Tapanez"
                        },
                        new
                        {
                            ID = 40,
                            Addresses = "Some Adress 39",
                            DateofBirth = new DateTime(1968, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5439),
                            FirstName = "Jhon",
                            PersonalPhoto = "img_avatar1.png",
                            PhoneNumber = "91740062",
                            SecondName = "Garcia"
                        },
                        new
                        {
                            ID = 41,
                            Addresses = "Some Adress 40",
                            DateofBirth = new DateTime(1971, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5455),
                            FirstName = "Brayan",
                            PersonalPhoto = "img_avatar2.png",
                            PhoneNumber = "54076713",
                            SecondName = "Garcia"
                        },
                        new
                        {
                            ID = 42,
                            Addresses = "Some Adress 41",
                            DateofBirth = new DateTime(1971, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5472),
                            FirstName = "Tedd",
                            PersonalPhoto = "img_avatar1.png",
                            PhoneNumber = "86577617",
                            SecondName = "Garcia"
                        },
                        new
                        {
                            ID = 43,
                            Addresses = "Some Adress 42",
                            DateofBirth = new DateTime(1991, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5489),
                            FirstName = "Carlos",
                            PersonalPhoto = "img_avatar4.png",
                            PhoneNumber = "50132924",
                            SecondName = "Fernandez"
                        },
                        new
                        {
                            ID = 44,
                            Addresses = "Some Adress 43",
                            DateofBirth = new DateTime(1976, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5505),
                            FirstName = "Miguel",
                            PersonalPhoto = "img_avatar3.png",
                            PhoneNumber = "25738739",
                            SecondName = "Hernandez"
                        },
                        new
                        {
                            ID = 45,
                            Addresses = "Some Adress 44",
                            DateofBirth = new DateTime(1972, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5521),
                            FirstName = "Tedd",
                            PersonalPhoto = "img_avatar3.png",
                            PhoneNumber = "59226707",
                            SecondName = "Doe"
                        },
                        new
                        {
                            ID = 46,
                            Addresses = "Some Adress 45",
                            DateofBirth = new DateTime(1995, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5537),
                            FirstName = "Miguel",
                            PersonalPhoto = "img_avatar1.png",
                            PhoneNumber = "41031395",
                            SecondName = "Lee"
                        },
                        new
                        {
                            ID = 47,
                            Addresses = "Some Adress 46",
                            DateofBirth = new DateTime(1965, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5553),
                            FirstName = "Juliet",
                            PersonalPhoto = "img_avatar4.png",
                            PhoneNumber = "72186539",
                            SecondName = "Tapanez"
                        },
                        new
                        {
                            ID = 48,
                            Addresses = "Some Adress 47",
                            DateofBirth = new DateTime(1985, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5569),
                            FirstName = "Marcos",
                            PersonalPhoto = "img_avatar3.png",
                            PhoneNumber = "63907733",
                            SecondName = "Stampton"
                        },
                        new
                        {
                            ID = 49,
                            Addresses = "Some Adress 48",
                            DateofBirth = new DateTime(1950, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5585),
                            FirstName = "Brayan",
                            PersonalPhoto = "img_avatar3.png",
                            PhoneNumber = "45525049",
                            SecondName = "Hernandez"
                        },
                        new
                        {
                            ID = 50,
                            Addresses = "Some Adress 49",
                            DateofBirth = new DateTime(1951, 6, 4, 10, 12, 40, 530, DateTimeKind.Local).AddTicks(5602),
                            FirstName = "Juliet",
                            PersonalPhoto = "img_avatar4.png",
                            PhoneNumber = "96044041",
                            SecondName = "Stampton"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
