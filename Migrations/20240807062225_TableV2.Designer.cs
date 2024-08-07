﻿// <auto-generated />
using EFCore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCore.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    [Migration("20240807062225_TableV2")]
    partial class TableV2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFCore.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EFCore.Models.Workstattion", b =>
                {
                    b.Property<int>("WorkStationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WorkStationId"));

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("WSCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WorkStationId");

                    b.HasIndex("EmployeeId")
                        .IsUnique();

                    b.ToTable("workstattions");
                });

            modelBuilder.Entity("EFCore.Models.Workstattion", b =>
                {
                    b.HasOne("EFCore.Models.Employee", "Employee")
                        .WithOne("workstattion")
                        .HasForeignKey("EFCore.Models.Workstattion", "EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("EFCore.Models.Employee", b =>
                {
                    b.Navigation("workstattion")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}