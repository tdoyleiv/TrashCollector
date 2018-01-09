namespace GarbageCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bills",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Amount = c.Int(nullable: false),
                        PaymentMethod = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Bills");
        }
    }
}
