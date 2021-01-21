namespace EFWeather.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WeatherItems", "Temp", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.WeatherItems", "Fuktighet", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.WeatherItems", "MinstTemp");
            DropColumn("dbo.WeatherItems", "MaxTemp");
        }
        
        public override void Down()
        {
            AddColumn("dbo.WeatherItems", "MaxTemp", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.WeatherItems", "MinstTemp", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.WeatherItems", "Fuktighet");
            DropColumn("dbo.WeatherItems", "Temp");
        }
    }
}
