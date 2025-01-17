﻿// <auto-generated />
using System;
using EFCore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCore.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    partial class EmployeeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFCore.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("departments");
                });

            modelBuilder.Entity("EFCore.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentID");

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

            modelBuilder.Entity("EFCore.Models.Employee", b =>
                {
                    b.HasOne("EFCore.Models.Department", "department")
                        .WithMany("employees")
                        .HasForeignKey("DepartmentID");

                    b.Navigation("department");
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

            modelBuilder.Entity("EFCore.Models.Department", b =>
                {
                    b.Navigation("employees");
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
