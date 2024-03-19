using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace backendServer.Migrations
{
    /// <inheritdoc />
    public partial class initial_migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brand",
                columns: table => new
                {
                    BrandID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BrandName = table.Column<string>(type: "text", nullable: false),
                    CompanyName = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand", x => x.BrandID);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    ProductCategoryID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductCategoryName = table.Column<string>(type: "text", nullable: false),
                    ParentProductCategoryID = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.ProductCategoryID);
                    table.ForeignKey(
                        name: "FK_Category_Category_ParentProductCategoryID",
                        column: x => x.ParentProductCategoryID,
                        principalTable: "Category",
                        principalColumn: "ProductCategoryID");
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    EmailID = table.Column<string>(type: "text", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: false),
                    DateOfBirth = table.Column<DateOnly>(type: "date", nullable: false),
                    MobileNumber = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "OptionsGrid",
                columns: table => new
                {
                    OptionGridID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OptionGridName = table.Column<string>(type: "text", nullable: true),
                    OptionGridDescription = table.Column<string>(type: "text", nullable: true),
                    ProductList = table.Column<string>(type: "jsonb", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OptionsGrid", x => x.OptionGridID);
                });

            migrationBuilder.CreateTable(
                name: "ProductColor",
                columns: table => new
                {
                    ProductColorID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductColorName = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductColor", x => x.ProductColorID);
                });

            migrationBuilder.CreateTable(
                name: "Seller",
                columns: table => new
                {
                    SellerID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ContactPersonName = table.Column<string>(type: "text", nullable: false),
                    CompanyName = table.Column<string>(type: "text", nullable: false),
                    ContactPersonEmailID = table.Column<string>(type: "text", nullable: false),
                    CompanyEmailID = table.Column<string>(type: "text", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: false),
                    ContactPersonPhone = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seller", x => x.SellerID);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    AddressId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AddressName = table.Column<string>(type: "text", nullable: true),
                    AddressContactName = table.Column<string>(type: "text", nullable: false),
                    MobileNumber = table.Column<string>(type: "text", nullable: false),
                    EmailID = table.Column<string>(type: "text", nullable: false),
                    AddressLine1 = table.Column<string>(type: "text", nullable: false),
                    AddressLine2 = table.Column<string>(type: "text", nullable: false),
                    Landmark = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: false),
                    State = table.Column<string>(type: "text", nullable: false),
                    PostalCode = table.Column<string>(type: "text", nullable: false),
                    Country = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CustomerID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.AddressId);
                    table.ForeignKey(
                        name: "FK_Address_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID");
                });

            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    CartId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CustomerID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.CartId);
                    table.ForeignKey(
                        name: "FK_Cart_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wishlist",
                columns: table => new
                {
                    WishlistId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CustomerID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wishlist", x => x.WishlistId);
                    table.ForeignKey(
                        name: "FK_Wishlist_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductName = table.Column<string>(type: "text", nullable: false),
                    ProductDescription = table.Column<string>(type: "jsonb", nullable: false),
                    ProductPrice = table.Column<float>(type: "real", nullable: false),
                    ProductThumbnailLocation = table.Column<string>(type: "text", nullable: true),
                    AboutTheProduct = table.Column<string>(type: "jsonb", nullable: false),
                    BrandID = table.Column<long>(type: "bigint", nullable: false),
                    OptionGridID = table.Column<long>(type: "bigint", nullable: false),
                    ProductCategoryID = table.Column<long>(type: "bigint", nullable: false),
                    ProductColorID = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Product_Brand_BrandID",
                        column: x => x.BrandID,
                        principalTable: "Brand",
                        principalColumn: "BrandID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_Category_ProductCategoryID",
                        column: x => x.ProductCategoryID,
                        principalTable: "Category",
                        principalColumn: "ProductCategoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_OptionsGrid_OptionGridID",
                        column: x => x.OptionGridID,
                        principalTable: "OptionsGrid",
                        principalColumn: "OptionGridID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_ProductColor_ProductColorID",
                        column: x => x.ProductColorID,
                        principalTable: "ProductColor",
                        principalColumn: "ProductColorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BillingAddress",
                columns: table => new
                {
                    BillingAddressId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AddressId = table.Column<long>(type: "bigint", nullable: false),
                    SellerId = table.Column<long>(type: "bigint", nullable: false),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillingAddress", x => x.BillingAddressId);
                    table.ForeignKey(
                        name: "FK_BillingAddress_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BillingAddress_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BillingAddress_Seller_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Seller",
                        principalColumn: "SellerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerAddress",
                columns: table => new
                {
                    CustomerAddressId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AddressId = table.Column<long>(type: "bigint", nullable: false),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerAddress", x => x.CustomerAddressId);
                    table.ForeignKey(
                        name: "FK_CustomerAddress_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerAddress_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SellerAddress",
                columns: table => new
                {
                    SellerAddressId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AddressId = table.Column<long>(type: "bigint", nullable: false),
                    SellerId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SellerAddress", x => x.SellerAddressId);
                    table.ForeignKey(
                        name: "FK_SellerAddress_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SellerAddress_Seller_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Seller",
                        principalColumn: "SellerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShippingAddress",
                columns: table => new
                {
                    ShippingAddressId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AddressId = table.Column<long>(type: "bigint", nullable: false),
                    SellerId = table.Column<long>(type: "bigint", nullable: false),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingAddress", x => x.ShippingAddressId);
                    table.ForeignKey(
                        name: "FK_ShippingAddress_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShippingAddress_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShippingAddress_Seller_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Seller",
                        principalColumn: "SellerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductImageSet",
                columns: table => new
                {
                    ProductImageSetID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ImageSetDirectory = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ProductID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImageSet", x => x.ProductImageSetID);
                    table.ForeignKey(
                        name: "FK_ProductImageSet_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductItems",
                columns: table => new
                {
                    ProductItemID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductDiscount = table.Column<float>(type: "real", nullable: false),
                    ProductPostalCode = table.Column<string>(type: "text", nullable: false),
                    ProductInventory = table.Column<string>(type: "jsonb", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ProductID = table.Column<long>(type: "bigint", nullable: false),
                    SellerID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductItems", x => x.ProductItemID);
                    table.ForeignKey(
                        name: "FK_ProductItems_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductItems_Seller_SellerID",
                        column: x => x.SellerID,
                        principalTable: "Seller",
                        principalColumn: "SellerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WishlistItem",
                columns: table => new
                {
                    WishlistItemId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    WishlistItemQuantity = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ProductID = table.Column<long>(type: "bigint", nullable: false),
                    WishlistID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WishlistItem", x => x.WishlistItemId);
                    table.ForeignKey(
                        name: "FK_WishlistItem_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WishlistItem_Wishlist_WishlistID",
                        column: x => x.WishlistID,
                        principalTable: "Wishlist",
                        principalColumn: "WishlistId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrderFinalAmount = table.Column<long>(type: "bigint", nullable: false),
                    TrackingInformation = table.Column<string>(type: "jsonb", nullable: false),
                    EstimatedDeliveryDate = table.Column<DateOnly>(type: "date", nullable: false),
                    OrderStatus = table.Column<string>(type: "text", nullable: false),
                    ShippingMethod = table.Column<string>(type: "text", nullable: false),
                    ShippingCost = table.Column<string>(type: "text", nullable: false),
                    PromoCode = table.Column<string>(type: "text", nullable: true),
                    OrderDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ShippingAddressID = table.Column<long>(type: "bigint", nullable: false),
                    BillingAddressID = table.Column<long>(type: "bigint", nullable: false),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false),
                    SellerId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Order_BillingAddress_BillingAddressID",
                        column: x => x.BillingAddressID,
                        principalTable: "BillingAddress",
                        principalColumn: "BillingAddressId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_Seller_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Seller",
                        principalColumn: "SellerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_ShippingAddress_ShippingAddressID",
                        column: x => x.ShippingAddressID,
                        principalTable: "ShippingAddress",
                        principalColumn: "ShippingAddressId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartItem",
                columns: table => new
                {
                    CartItemId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CartItemQuantity = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ProductItemID = table.Column<long>(type: "bigint", nullable: false),
                    CartID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItem", x => x.CartItemId);
                    table.ForeignKey(
                        name: "FK_CartItem_Cart_CartID",
                        column: x => x.CartID,
                        principalTable: "Cart",
                        principalColumn: "CartId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItem_ProductItems_ProductItemID",
                        column: x => x.ProductItemID,
                        principalTable: "ProductItems",
                        principalColumn: "ProductItemID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    OrderItemId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrderItemQuantity = table.Column<int>(type: "integer", nullable: false),
                    OrderItemBasePrice = table.Column<float>(type: "real", nullable: false),
                    OrderItemDiscount = table.Column<float>(type: "real", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ProductItemID = table.Column<long>(type: "bigint", nullable: false),
                    OrderID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.OrderItemId);
                    table.ForeignKey(
                        name: "FK_OrderItem_Order_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItem_ProductItems_ProductItemID",
                        column: x => x.ProductItemID,
                        principalTable: "ProductItems",
                        principalColumn: "ProductItemID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_CustomerID",
                table: "Address",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_BillingAddress_AddressId",
                table: "BillingAddress",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_BillingAddress_CustomerId",
                table: "BillingAddress",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_BillingAddress_SellerId",
                table: "BillingAddress",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_CustomerID",
                table: "Cart",
                column: "CustomerID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_CartID",
                table: "CartItem",
                column: "CartID");

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_ProductItemID",
                table: "CartItem",
                column: "ProductItemID");

            migrationBuilder.CreateIndex(
                name: "IX_Category_ParentProductCategoryID",
                table: "Category",
                column: "ParentProductCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddress_AddressId",
                table: "CustomerAddress",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddress_CustomerId",
                table: "CustomerAddress",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_BillingAddressID",
                table: "Order",
                column: "BillingAddressID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerId",
                table: "Order",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_SellerId",
                table: "Order",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ShippingAddressID",
                table: "Order",
                column: "ShippingAddressID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderID",
                table: "OrderItem",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_ProductItemID",
                table: "OrderItem",
                column: "ProductItemID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_BrandID",
                table: "Product",
                column: "BrandID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_OptionGridID",
                table: "Product",
                column: "OptionGridID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductCategoryID",
                table: "Product",
                column: "ProductCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductColorID",
                table: "Product",
                column: "ProductColorID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImageSet_ProductID",
                table: "ProductImageSet",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductItems_ProductID",
                table: "ProductItems",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductItems_SellerID",
                table: "ProductItems",
                column: "SellerID");

            migrationBuilder.CreateIndex(
                name: "IX_SellerAddress_AddressId",
                table: "SellerAddress",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_SellerAddress_SellerId",
                table: "SellerAddress",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_ShippingAddress_AddressId",
                table: "ShippingAddress",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_ShippingAddress_CustomerId",
                table: "ShippingAddress",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ShippingAddress_SellerId",
                table: "ShippingAddress",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_Wishlist_CustomerID",
                table: "Wishlist",
                column: "CustomerID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WishlistItem_ProductID",
                table: "WishlistItem",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_WishlistItem_WishlistID",
                table: "WishlistItem",
                column: "WishlistID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItem");

            migrationBuilder.DropTable(
                name: "CustomerAddress");

            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "ProductImageSet");

            migrationBuilder.DropTable(
                name: "SellerAddress");

            migrationBuilder.DropTable(
                name: "WishlistItem");

            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "ProductItems");

            migrationBuilder.DropTable(
                name: "Wishlist");

            migrationBuilder.DropTable(
                name: "BillingAddress");

            migrationBuilder.DropTable(
                name: "ShippingAddress");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Seller");

            migrationBuilder.DropTable(
                name: "Brand");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "OptionsGrid");

            migrationBuilder.DropTable(
                name: "ProductColor");

            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
