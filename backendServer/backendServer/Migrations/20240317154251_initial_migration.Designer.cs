﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PostgreSQL.Data;

#nullable disable

namespace backendServer.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240317154251_initial_migration")]
    partial class initial_migration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("backendServer.Models.Address", b =>
                {
                    b.Property<long>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("AddressId"));

                    b.Property<string>("AddressContactName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("AddressLine2")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("AddressName")
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("CustomerID")
                        .HasColumnType("bigint");

                    b.Property<string>("EmailID")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Landmark")
                        .HasColumnType("text");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("AddressId");

                    b.HasIndex("CustomerID");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("backendServer.Models.BillingAddress", b =>
                {
                    b.Property<long>("BillingAddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("BillingAddressId"));

                    b.Property<long>("AddressId")
                        .HasColumnType("bigint");

                    b.Property<long>("CustomerId")
                        .HasColumnType("bigint");

                    b.Property<long>("SellerId")
                        .HasColumnType("bigint");

                    b.HasKey("BillingAddressId");

                    b.HasIndex("AddressId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("SellerId");

                    b.ToTable("BillingAddress");
                });

            modelBuilder.Entity("backendServer.Models.Brand", b =>
                {
                    b.Property<long>("BrandID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("BrandID"));

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("BrandID");

                    b.ToTable("Brand");
                });

            modelBuilder.Entity("backendServer.Models.Cart", b =>
                {
                    b.Property<long>("CartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("CartId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("CustomerID")
                        .HasColumnType("bigint");

                    b.HasKey("CartId");

                    b.HasIndex("CustomerID")
                        .IsUnique();

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("backendServer.Models.CartItem", b =>
                {
                    b.Property<long>("CartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("CartItemId"));

                    b.Property<long>("CartID")
                        .HasColumnType("bigint");

                    b.Property<int>("CartItemQuantity")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("ProductItemID")
                        .HasColumnType("bigint");

                    b.HasKey("CartItemId");

                    b.HasIndex("CartID");

                    b.HasIndex("ProductItemID");

                    b.ToTable("CartItem");
                });

            modelBuilder.Entity("backendServer.Models.Customer", b =>
                {
                    b.Property<long>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("CustomerID"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("EmailID")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("CustomerID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("backendServer.Models.CustomerAddress", b =>
                {
                    b.Property<long>("CustomerAddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("CustomerAddressId"));

                    b.Property<long>("AddressId")
                        .HasColumnType("bigint");

                    b.Property<long>("CustomerId")
                        .HasColumnType("bigint");

                    b.HasKey("CustomerAddressId");

                    b.HasIndex("AddressId");

                    b.HasIndex("CustomerId");

                    b.ToTable("CustomerAddress");
                });

            modelBuilder.Entity("backendServer.Models.OptionsGrid", b =>
                {
                    b.Property<long>("OptionGridID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("OptionGridID"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("OptionGridDescription")
                        .HasColumnType("text");

                    b.Property<string>("OptionGridName")
                        .HasColumnType("text");

                    b.Property<string>("ProductList")
                        .HasColumnType("jsonb");

                    b.HasKey("OptionGridID");

                    b.ToTable("OptionsGrid");
                });

            modelBuilder.Entity("backendServer.Models.Order", b =>
                {
                    b.Property<long>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("OrderID"));

                    b.Property<long>("BillingAddressID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("CustomerId")
                        .HasColumnType("bigint");

                    b.Property<DateOnly>("EstimatedDeliveryDate")
                        .HasColumnType("date");

                    b.Property<DateTime>("OrderDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("OrderFinalAmount")
                        .HasColumnType("bigint");

                    b.Property<string>("OrderStatus")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PromoCode")
                        .HasColumnType("text");

                    b.Property<long>("SellerId")
                        .HasColumnType("bigint");

                    b.Property<long>("ShippingAddressID")
                        .HasColumnType("bigint");

                    b.Property<string>("ShippingCost")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ShippingMethod")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TrackingInformation")
                        .IsRequired()
                        .HasColumnType("jsonb");

                    b.HasKey("OrderID");

                    b.HasIndex("BillingAddressID");

                    b.HasIndex("CustomerId");

                    b.HasIndex("SellerId");

                    b.HasIndex("ShippingAddressID");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("backendServer.Models.OrderItem", b =>
                {
                    b.Property<long>("OrderItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("OrderItemId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("OrderID")
                        .HasColumnType("bigint");

                    b.Property<float>("OrderItemBasePrice")
                        .HasColumnType("real");

                    b.Property<float>("OrderItemDiscount")
                        .HasColumnType("real");

                    b.Property<int>("OrderItemQuantity")
                        .HasColumnType("integer");

                    b.Property<long>("ProductItemID")
                        .HasColumnType("bigint");

                    b.HasKey("OrderItemId");

                    b.HasIndex("OrderID");

                    b.HasIndex("ProductItemID");

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("backendServer.Models.Product", b =>
                {
                    b.Property<long>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ProductID"));

                    b.Property<string>("AboutTheProduct")
                        .IsRequired()
                        .HasColumnType("jsonb");

                    b.Property<long>("BrandID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("OptionGridID")
                        .HasColumnType("bigint");

                    b.Property<long>("ProductCategoryID")
                        .HasColumnType("bigint");

                    b.Property<long>("ProductColorID")
                        .HasColumnType("bigint");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasColumnType("jsonb");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<float>("ProductPrice")
                        .HasColumnType("real");

                    b.Property<string>("ProductThumbnailLocation")
                        .HasColumnType("text");

                    b.HasKey("ProductID");

                    b.HasIndex("BrandID");

                    b.HasIndex("OptionGridID");

                    b.HasIndex("ProductCategoryID");

                    b.HasIndex("ProductColorID");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("backendServer.Models.ProductCategory", b =>
                {
                    b.Property<long>("ProductCategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ProductCategoryID"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("ParentProductCategoryID")
                        .HasColumnType("bigint");

                    b.Property<string>("ProductCategoryName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ProductCategoryID");

                    b.HasIndex("ParentProductCategoryID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("backendServer.Models.ProductColor", b =>
                {
                    b.Property<long>("ProductColorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ProductColorID"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ProductColorName")
                        .HasColumnType("text");

                    b.HasKey("ProductColorID");

                    b.ToTable("ProductColor");
                });

            modelBuilder.Entity("backendServer.Models.ProductImageSet", b =>
                {
                    b.Property<long>("ProductImageSetID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ProductImageSetID"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ImageSetDirectory")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("ProductID")
                        .HasColumnType("bigint");

                    b.HasKey("ProductImageSetID");

                    b.HasIndex("ProductID");

                    b.ToTable("ProductImageSet");
                });

            modelBuilder.Entity("backendServer.Models.ProductItem", b =>
                {
                    b.Property<long>("ProductItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ProductItemID"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<float>("ProductDiscount")
                        .HasColumnType("real");

                    b.Property<long>("ProductID")
                        .HasColumnType("bigint");

                    b.Property<string>("ProductInventory")
                        .IsRequired()
                        .HasColumnType("jsonb");

                    b.Property<string>("ProductPostalCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("SellerID")
                        .HasColumnType("bigint");

                    b.HasKey("ProductItemID");

                    b.HasIndex("ProductID");

                    b.HasIndex("SellerID");

                    b.ToTable("ProductItems");
                });

            modelBuilder.Entity("backendServer.Models.Seller", b =>
                {
                    b.Property<long>("SellerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("SellerID"));

                    b.Property<string>("CompanyEmailID")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ContactPersonEmailID")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ContactPersonName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ContactPersonPhone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("SellerID");

                    b.ToTable("Seller");
                });

            modelBuilder.Entity("backendServer.Models.SellerAddress", b =>
                {
                    b.Property<long>("SellerAddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("SellerAddressId"));

                    b.Property<long>("AddressId")
                        .HasColumnType("bigint");

                    b.Property<long>("SellerId")
                        .HasColumnType("bigint");

                    b.HasKey("SellerAddressId");

                    b.HasIndex("AddressId");

                    b.HasIndex("SellerId");

                    b.ToTable("SellerAddress");
                });

            modelBuilder.Entity("backendServer.Models.ShippingAddress", b =>
                {
                    b.Property<long>("ShippingAddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ShippingAddressId"));

                    b.Property<long>("AddressId")
                        .HasColumnType("bigint");

                    b.Property<long>("CustomerId")
                        .HasColumnType("bigint");

                    b.Property<long>("SellerId")
                        .HasColumnType("bigint");

                    b.HasKey("ShippingAddressId");

                    b.HasIndex("AddressId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("SellerId");

                    b.ToTable("ShippingAddress");
                });

            modelBuilder.Entity("backendServer.Models.Wishlist", b =>
                {
                    b.Property<long>("WishlistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("WishlistId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("CustomerID")
                        .HasColumnType("bigint");

                    b.HasKey("WishlistId");

                    b.HasIndex("CustomerID")
                        .IsUnique();

                    b.ToTable("Wishlist");
                });

            modelBuilder.Entity("backendServer.Models.WishlistItem", b =>
                {
                    b.Property<long>("WishlistItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("WishlistItemId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("ProductID")
                        .HasColumnType("bigint");

                    b.Property<long>("WishlistID")
                        .HasColumnType("bigint");

                    b.Property<int>("WishlistItemQuantity")
                        .HasColumnType("integer");

                    b.HasKey("WishlistItemId");

                    b.HasIndex("ProductID");

                    b.HasIndex("WishlistID");

                    b.ToTable("WishlistItem");
                });

            modelBuilder.Entity("backendServer.Models.Address", b =>
                {
                    b.HasOne("backendServer.Models.Customer", null)
                        .WithMany("Addresses")
                        .HasForeignKey("CustomerID");
                });

            modelBuilder.Entity("backendServer.Models.BillingAddress", b =>
                {
                    b.HasOne("backendServer.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backendServer.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backendServer.Models.Seller", "Seller")
                        .WithMany()
                        .HasForeignKey("SellerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Customer");

                    b.Navigation("Seller");
                });

            modelBuilder.Entity("backendServer.Models.Cart", b =>
                {
                    b.HasOne("backendServer.Models.Customer", "Customer")
                        .WithOne("Cart")
                        .HasForeignKey("backendServer.Models.Cart", "CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("backendServer.Models.CartItem", b =>
                {
                    b.HasOne("backendServer.Models.Cart", "Cart")
                        .WithMany("CartItems")
                        .HasForeignKey("CartID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backendServer.Models.ProductItem", "ProductItem")
                        .WithMany()
                        .HasForeignKey("ProductItemID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("ProductItem");
                });

            modelBuilder.Entity("backendServer.Models.CustomerAddress", b =>
                {
                    b.HasOne("backendServer.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backendServer.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("backendServer.Models.Order", b =>
                {
                    b.HasOne("backendServer.Models.BillingAddress", "BillingAddress")
                        .WithMany()
                        .HasForeignKey("BillingAddressID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backendServer.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backendServer.Models.Seller", "Seller")
                        .WithMany("orders")
                        .HasForeignKey("SellerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backendServer.Models.ShippingAddress", "ShippingAddress")
                        .WithMany()
                        .HasForeignKey("ShippingAddressID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BillingAddress");

                    b.Navigation("Customer");

                    b.Navigation("Seller");

                    b.Navigation("ShippingAddress");
                });

            modelBuilder.Entity("backendServer.Models.OrderItem", b =>
                {
                    b.HasOne("backendServer.Models.Order", "Order")
                        .WithMany("orderItems")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backendServer.Models.ProductItem", "ProductItem")
                        .WithMany()
                        .HasForeignKey("ProductItemID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("ProductItem");
                });

            modelBuilder.Entity("backendServer.Models.Product", b =>
                {
                    b.HasOne("backendServer.Models.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backendServer.Models.OptionsGrid", "OptionsGrid")
                        .WithMany()
                        .HasForeignKey("OptionGridID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backendServer.Models.ProductCategory", "productCategory")
                        .WithMany("Products")
                        .HasForeignKey("ProductCategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backendServer.Models.ProductColor", "productColor")
                        .WithMany("Products")
                        .HasForeignKey("ProductColorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("OptionsGrid");

                    b.Navigation("productCategory");

                    b.Navigation("productColor");
                });

            modelBuilder.Entity("backendServer.Models.ProductCategory", b =>
                {
                    b.HasOne("backendServer.Models.ProductCategory", "ParentProductCategory")
                        .WithMany("ChildProductCategories")
                        .HasForeignKey("ParentProductCategoryID");

                    b.Navigation("ParentProductCategory");
                });

            modelBuilder.Entity("backendServer.Models.ProductImageSet", b =>
                {
                    b.HasOne("backendServer.Models.Product", "Products")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Products");
                });

            modelBuilder.Entity("backendServer.Models.ProductItem", b =>
                {
                    b.HasOne("backendServer.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backendServer.Models.Seller", "Seller")
                        .WithMany("ProductItems")
                        .HasForeignKey("SellerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Seller");
                });

            modelBuilder.Entity("backendServer.Models.SellerAddress", b =>
                {
                    b.HasOne("backendServer.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backendServer.Models.Seller", "Seller")
                        .WithMany("sellerAddress")
                        .HasForeignKey("SellerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Seller");
                });

            modelBuilder.Entity("backendServer.Models.ShippingAddress", b =>
                {
                    b.HasOne("backendServer.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backendServer.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backendServer.Models.Seller", "Seller")
                        .WithMany()
                        .HasForeignKey("SellerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Customer");

                    b.Navigation("Seller");
                });

            modelBuilder.Entity("backendServer.Models.Wishlist", b =>
                {
                    b.HasOne("backendServer.Models.Customer", "Customer")
                        .WithOne("Wishlist")
                        .HasForeignKey("backendServer.Models.Wishlist", "CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("backendServer.Models.WishlistItem", b =>
                {
                    b.HasOne("backendServer.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backendServer.Models.Wishlist", "Wishlist")
                        .WithMany("wishlistItems")
                        .HasForeignKey("WishlistID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Wishlist");
                });

            modelBuilder.Entity("backendServer.Models.Brand", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("backendServer.Models.Cart", b =>
                {
                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("backendServer.Models.Customer", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("Cart")
                        .IsRequired();

                    b.Navigation("Orders");

                    b.Navigation("Wishlist")
                        .IsRequired();
                });

            modelBuilder.Entity("backendServer.Models.Order", b =>
                {
                    b.Navigation("orderItems");
                });

            modelBuilder.Entity("backendServer.Models.ProductCategory", b =>
                {
                    b.Navigation("ChildProductCategories");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("backendServer.Models.ProductColor", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("backendServer.Models.Seller", b =>
                {
                    b.Navigation("ProductItems");

                    b.Navigation("orders");

                    b.Navigation("sellerAddress");
                });

            modelBuilder.Entity("backendServer.Models.Wishlist", b =>
                {
                    b.Navigation("wishlistItems");
                });
#pragma warning restore 612, 618
        }
    }
}