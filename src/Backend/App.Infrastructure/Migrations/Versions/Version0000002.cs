using FluentMigrator;

namespace App.Infrastructure.Migrations.Versions
{
    [Migration(DatabaseVersions.TABLE_ORDER, "Create table to save the orders' information")]
    public class Version0000002 : VersionBase
    {
        private const string PRODUCT_TABLE_NAME = "Products";
        private const string ORDER_TABLE_NAME = "Orders";
        private const string ORDER_ITEM_TABLE_NAME = "OrderItems";

        public override void Up()
        {
            //CreateTable(ORDER_TABLE_NAME)
            //    .WithColumn("CustomerName").AsString(255).NotNullable()
            //    .WithColumn("OrderDate").AsDateTime().NotNullable()
            //    .WithColumn("Status").AsString(100).NotNullable();

            //CreateTable(ORDER_ITEM_TABLE_NAME)
            //    .WithColumn("OrderId").AsInt32().NotNullable().ForeignKey("FK_OrderItem_Order_Id", ORDER_TABLE_NAME, "Id")
            //    .WithColumn("ProductCode").AsString(255).NotNullable().ForeignKey("FK_OrderItem_Product_Id", PRODUCT_TABLE_NAME, "Code")
            //    .WithColumn("Quantity").AsInt32().NotNullable()
            //    .WithColumn("UnitPrice").AsString(100).NotNullable();

       
            CreateTable(ORDER_TABLE_NAME)
                .WithColumn("CustomerName").AsString(255).NotNullable()
                .WithColumn("OrderDate").AsDateTime().NotNullable()
                .WithColumn("Status").AsString(100).NotNullable();

            
            CreateTable(ORDER_ITEM_TABLE_NAME)
                .WithColumn("OrderId").AsInt64().NotNullable() 
                .WithColumn("ProductCode").AsString(255).NotNullable()
                .WithColumn("Quantity").AsInt32().NotNullable()
                .WithColumn("UnitPrice").AsString(100).NotNullable();

            Create.ForeignKey("FK_OrderItem_Order_Id")
                .FromTable(ORDER_ITEM_TABLE_NAME).ForeignColumn("OrderId")
                .ToTable(ORDER_TABLE_NAME).PrimaryColumn("Id");

            Create.ForeignKey("FK_OrderItem_Product_Code")
                .FromTable(ORDER_ITEM_TABLE_NAME).ForeignColumn("ProductCode")
                .ToTable(PRODUCT_TABLE_NAME).PrimaryColumn("Code");

        }
    }
}
