﻿// <auto-generated />
using System;
using LocationMap.DataLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LocationMap.DataLayer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("13980914140404_V2019_12_05_1733")]
    partial class V2019_12_05_1733
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LocationMap.DomainClasses.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FileName");

                    b.Property<string>("Lat");

                    b.Property<string>("Lng");

                    b.Property<string>("LocationName");

                    b.Property<int?>("LocationTypeId");

                    b.HasKey("Id");

                    b.HasIndex("LocationTypeId");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("LocationMap.DomainClasses.LocationType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("LocationType");
                });

            modelBuilder.Entity("LocationMap.DomainClasses.Location", b =>
                {
                    b.HasOne("LocationMap.DomainClasses.LocationType", "LocationType")
                        .WithMany("Location")
                        .HasForeignKey("LocationTypeId")
                        .HasConstraintName("FK_Location_LocationType");
                });
#pragma warning restore 612, 618
        }
    }
}
