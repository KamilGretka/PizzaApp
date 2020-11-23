namespace PizzaApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MisspelligChange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrderHistories", "Address", c => c.String());
            DropColumn("dbo.OrderHistories", "Adress");
        }
        
        public override void Down()
        {
            AddColumn("dbo.OrderHistories", "Adress", c => c.String());
            DropColumn("dbo.OrderHistories", "Address");
        }
    }
}
