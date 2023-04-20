﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAppBanHang.Presistence;

#nullable disable

namespace WebAppBanHang.Presistence.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebAppBanHang.Entity.Account", b =>
                {
                    b.Property<string>("UserName")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("Create_At")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Delete_At")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Modifiled_At")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("UserName");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("WebAppBanHang.Entity.AccountGroup", b =>
                {
                    b.Property<string>("AccountTypeId")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasIndex("AccountTypeId");

                    b.HasIndex("UserName");

                    b.ToTable("AccountGroup");
                });

            modelBuilder.Entity("WebAppBanHang.Entity.AccountPermission", b =>
                {
                    b.Property<string>("PermissionID")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("TypeID")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasIndex("PermissionID");

                    b.HasIndex("TypeID");

                    b.ToTable("AccountPermission");
                });

            modelBuilder.Entity("WebAppBanHang.Entity.AccountType", b =>
                {
                    b.Property<string>("AccountTypeID")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("Create_At")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Delete_At")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Modified_At")
                        .HasColumnType("datetime2");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("AccountTypeID");

                    b.ToTable("AccountType");
                });

            modelBuilder.Entity("WebAppBanHang.Entity.Brand", b =>
                {
                    b.Property<string>("BrandId")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("BrandId");

                    b.ToTable("Brand");
                });

            modelBuilder.Entity("WebAppBanHang.Entity.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryID"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CategoryID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("WebAppBanHang.Entity.Permission", b =>
                {
                    b.Property<string>("PermissionId")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PermissionName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("PermissionId");

                    b.ToTable("Permission");
                });

            modelBuilder.Entity("WebAppBanHang.Entity.Product", b =>
                {
                    b.Property<string>("Product_Line")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("AccountUserName")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("BrandId")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("CategoryID")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<DateTime>("Create_At")
                        .HasColumnType("datetime2");

                    b.Property<string>("Create_By")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("Delete_At")
                        .HasColumnType("datetime2");

                    b.Property<long>("Discount")
                        .HasMaxLength(3)
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Modified_At")
                        .HasColumnType("datetime2");

                    b.Property<int>("Price")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<string>("Product_Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Thumbnail")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Product_Line");

                    b.HasIndex("AccountUserName");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryID");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("WebAppBanHang.Entity.ProductImage", b =>
                {
                    b.Property<int>("ImageID")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(11)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ImageID"));

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ProductLine")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ImageID");

                    b.HasIndex("ProductLine");

                    b.ToTable("ProductImage");
                });

            modelBuilder.Entity("WebAppBanHang.Entity.ProductInfo", b =>
                {
                    b.Property<int>("Info_ID")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Info_ID"));

                    b.Property<string>("Product_Infomation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Product_Line")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Info_ID");

                    b.HasIndex("Product_Line");

                    b.ToTable("ProductInfo");
                });

            modelBuilder.Entity("WebAppBanHang.Entity.ProductWarranty", b =>
                {
                    b.Property<string>("Product_ID")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Product_Line")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("Purchased_At")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Warranty_Period")
                        .HasColumnType("datetime2");

                    b.HasKey("Product_ID");

                    b.HasIndex("Product_Line");

                    b.ToTable("ProductWarranty");
                });

            modelBuilder.Entity("WebAppBanHang.Entity.UserDetail", b =>
                {
                    b.Property<int>("UserDetailId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(11)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserDetailId"));

                    b.Property<string>("CityOrProvince")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("DetaledAddress")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("WardOrVillage")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("UserDetailId");

                    b.HasIndex("UserName");

                    b.ToTable("UserDetail");
                });

            modelBuilder.Entity("WebAppBanHang.Entity.AccountGroup", b =>
                {
                    b.HasOne("WebAppBanHang.Entity.AccountType", "AccountType")
                        .WithMany()
                        .HasForeignKey("AccountTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAppBanHang.Entity.Account", "Account")
                        .WithMany()
                        .HasForeignKey("UserName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("AccountType");
                });

            modelBuilder.Entity("WebAppBanHang.Entity.AccountPermission", b =>
                {
                    b.HasOne("WebAppBanHang.Entity.Permission", "Permissions")
                        .WithMany()
                        .HasForeignKey("PermissionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAppBanHang.Entity.AccountType", "AccountType")
                        .WithMany()
                        .HasForeignKey("TypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccountType");

                    b.Navigation("Permissions");
                });

            modelBuilder.Entity("WebAppBanHang.Entity.Product", b =>
                {
                    b.HasOne("WebAppBanHang.Entity.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountUserName");

                    b.HasOne("WebAppBanHang.Entity.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAppBanHang.Entity.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Brand");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("WebAppBanHang.Entity.ProductImage", b =>
                {
                    b.HasOne("WebAppBanHang.Entity.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductLine")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("WebAppBanHang.Entity.ProductInfo", b =>
                {
                    b.HasOne("WebAppBanHang.Entity.Product", "Product")
                        .WithMany()
                        .HasForeignKey("Product_Line")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("WebAppBanHang.Entity.ProductWarranty", b =>
                {
                    b.HasOne("WebAppBanHang.Entity.Product", "Product")
                        .WithMany()
                        .HasForeignKey("Product_Line")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("WebAppBanHang.Entity.UserDetail", b =>
                {
                    b.HasOne("WebAppBanHang.Entity.Account", "Account")
                        .WithMany()
                        .HasForeignKey("UserName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });
#pragma warning restore 612, 618
        }
    }
}
