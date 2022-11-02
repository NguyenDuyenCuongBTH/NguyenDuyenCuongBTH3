﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace NguyenDuyenCuongBTH3.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20221102094121_Employee")]
    partial class Employee
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("NguyenDuyenCuongBTH3.Models.Employee", b =>
                {
                    b.Property<string>("EmpId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EmpName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("EmpId");

                    b.ToTable("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}
