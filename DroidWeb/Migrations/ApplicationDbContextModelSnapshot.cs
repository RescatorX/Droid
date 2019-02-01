﻿// <auto-generated />
using System;
using DroidWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DroidWeb.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("DroidWeb.Data.Entities.Module", b =>
                {
                    b.Property<byte[]>("Id")
                        .ValueGeneratedOnAdd()
                        .HasConversion(new ValueConverter<byte[], byte[]>(v => default(byte[]), v => default(byte[]), new ConverterMappingHints(size: 16)));

                    b.Property<string>("Brand");

                    b.Property<string>("Name");

                    b.Property<string>("Type");

                    b.Property<string>("Version");

                    b.HasKey("Id");

                    b.ToTable("Module");
                });

            modelBuilder.Entity("DroidWeb.Data.Entities.Position", b =>
                {
                    b.Property<byte[]>("Id")
                        .ValueGeneratedOnAdd()
                        .HasConversion(new ValueConverter<byte[], byte[]>(v => default(byte[]), v => default(byte[]), new ConverterMappingHints(size: 16)));

                    b.Property<double?>("DeviationX");

                    b.Property<double?>("DeviationY");

                    b.Property<double?>("DeviationZ");

                    b.Property<byte[]>("ModuleId")
                        .HasConversion(new ValueConverter<byte[], byte[]>(v => default(byte[]), v => default(byte[]), new ConverterMappingHints(size: 16)));

                    b.Property<int>("Type");

                    b.Property<bool>("Valid");

                    b.Property<double?>("X");

                    b.Property<double?>("Y");

                    b.Property<double?>("Z");

                    b.HasKey("Id");

                    b.HasIndex("ModuleId");

                    b.ToTable("Position");
                });

            modelBuilder.Entity("DroidWeb.Data.Entities.Vehicle", b =>
                {
                    b.Property<byte[]>("Id")
                        .ValueGeneratedOnAdd()
                        .HasConversion(new ValueConverter<byte[], byte[]>(v => default(byte[]), v => default(byte[]), new ConverterMappingHints(size: 16)));

                    b.Property<string>("Name");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("Vehicle");
                });

            modelBuilder.Entity("DroidWeb.Data.Entities.Position", b =>
                {
                    b.HasOne("DroidWeb.Data.Entities.Module", "Module")
                        .WithMany()
                        .HasForeignKey("ModuleId");
                });
#pragma warning restore 612, 618
        }
    }
}