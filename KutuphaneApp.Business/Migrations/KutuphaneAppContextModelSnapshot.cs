﻿// <auto-generated />
using System;
using KutuphaneApp.Business.Concrate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KutuphaneApp.Business.Migrations
{
    [DbContext(typeof(KutuphaneAppContext))]
    partial class KutuphaneAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KutuphaneApp.Entity.Concrate.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AuthorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AuthorSurname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("KutuphaneApp.Entity.Concrate.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("BookName")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("KutuphaneApp.Entity.Concrate.BookDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("Page")
                        .HasColumnType("int");

                    b.Property<string>("Preface")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BookId")
                        .IsUnique();

                    b.ToTable("BookDetails");
                });

            modelBuilder.Entity("KutuphaneApp.Entity.Concrate.Cateogory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryName")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cateogorys");
                });

            modelBuilder.Entity("KutuphaneApp.Entity.Concrate.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BookDetailId")
                        .HasColumnType("int");

                    b.Property<int?>("PhotoId")
                        .HasColumnType("int");

                    b.Property<byte[]>("PhotoPaths")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.HasIndex("BookDetailId");

                    b.HasIndex("PhotoId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("KutuphaneApp.Entity.Concrate.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("KutuphaneApp.Entity.Concrate.Book", b =>
                {
                    b.HasOne("KutuphaneApp.Entity.Concrate.Author", null)
                        .WithMany("BookLists")
                        .HasForeignKey("AuthorId");
                });

            modelBuilder.Entity("KutuphaneApp.Entity.Concrate.BookDetail", b =>
                {
                    b.HasOne("KutuphaneApp.Entity.Concrate.Book", "Books")
                        .WithOne("BookDetails")
                        .HasForeignKey("KutuphaneApp.Entity.Concrate.BookDetail", "BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Books");
                });

            modelBuilder.Entity("KutuphaneApp.Entity.Concrate.Photo", b =>
                {
                    b.HasOne("KutuphaneApp.Entity.Concrate.BookDetail", null)
                        .WithMany("Photos")
                        .HasForeignKey("BookDetailId");

                    b.HasOne("KutuphaneApp.Entity.Concrate.Photo", null)
                        .WithMany("Photos")
                        .HasForeignKey("PhotoId");
                });

            modelBuilder.Entity("KutuphaneApp.Entity.Concrate.Author", b =>
                {
                    b.Navigation("BookLists");
                });

            modelBuilder.Entity("KutuphaneApp.Entity.Concrate.Book", b =>
                {
                    b.Navigation("BookDetails")
                        .IsRequired();
                });

            modelBuilder.Entity("KutuphaneApp.Entity.Concrate.BookDetail", b =>
                {
                    b.Navigation("Photos");
                });

            modelBuilder.Entity("KutuphaneApp.Entity.Concrate.Photo", b =>
                {
                    b.Navigation("Photos");
                });
#pragma warning restore 612, 618
        }
    }
}
