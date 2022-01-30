﻿// <auto-generated />
using DataStorage.EF.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataStorage.EF.Migrations
{
    [DbContext(typeof(DataStorageContext))]
    partial class DataStorageContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DataStorage.EF.Entities.ExpectedObject", b =>
                {
                    b.Property<string>("ObjectId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Repository")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ObjectId");

                    b.ToTable("ExpectedObjects");
                });
#pragma warning restore 612, 618
        }
    }
}