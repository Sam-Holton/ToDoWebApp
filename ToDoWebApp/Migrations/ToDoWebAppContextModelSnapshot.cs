﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToDoWebApp.Services;

namespace ToDoWebApp.Migrations
{
    [DbContext(typeof(ToDoWebAppContext))]
    partial class ToDoWebAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("ToDoWebApp.Models.DALModels.ToDoItemsDAL", b =>
                {
                    b.Property<int>("ItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("ItemCompleted")
                        .HasColumnType("bit");

                    b.Property<string>("ItemDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ItemDueDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ToDoUsersDAL")
                        .HasColumnType("int");

                    b.Property<int?>("ToDoUsersDALUserID")
                        .HasColumnType("int");

                    b.HasKey("ItemID");

                    b.HasIndex("ToDoUsersDALUserID");

                    b.ToTable("ToDoItems");
                });

            modelBuilder.Entity("ToDoWebApp.Models.DALModels.ToDoUsersDAL", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("UserEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPassword")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("ToDoUsers");
                });

            modelBuilder.Entity("ToDoWebApp.Models.DALModels.ToDoItemsDAL", b =>
                {
                    b.HasOne("ToDoWebApp.Models.DALModels.ToDoUsersDAL", null)
                        .WithMany("ToDoItems")
                        .HasForeignKey("ToDoUsersDALUserID");
                });

            modelBuilder.Entity("ToDoWebApp.Models.DALModels.ToDoUsersDAL", b =>
                {
                    b.Navigation("ToDoItems");
                });
#pragma warning restore 612, 618
        }
    }
}
