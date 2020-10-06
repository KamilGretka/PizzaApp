namespace PizzaApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderHistory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderHistories",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        OrderTime = c.DateTime(nullable: false),
                        Adress = c.String(),
                        OrderMessage = c.String(),
                        CustomerName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.OrderHistories");
        }
    }
}
