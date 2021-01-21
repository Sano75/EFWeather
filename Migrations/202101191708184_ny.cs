namespace EFWeather.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ny : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WeatherItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Datum = c.DateTime(nullable: false),
                        Utrymme = c.String(),
                        Minst = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Max = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WeatherItems");
        }
    }
}
