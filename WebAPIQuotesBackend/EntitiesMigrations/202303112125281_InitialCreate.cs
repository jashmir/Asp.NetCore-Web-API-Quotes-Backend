namespace WebAPIQuotesBackend.EntitiesMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Quotes",
                c => new
                    {
                        QuoteID = c.Int(nullable: false, identity: true),
                        QuoteType = c.String(),
                        Description = c.String(),
                        DueDate = c.DateTime(),
                        Premium = c.Decimal(precision: 18, scale: 2),
                        Sales = c.String(),
                    })
                .PrimaryKey(t => t.QuoteID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Quotes");
        }
    }
}
