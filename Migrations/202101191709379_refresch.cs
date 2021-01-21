namespace EFWeather.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class refresch : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WeatherItems", "MinstTemp", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.WeatherItems", "MaxTemp", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.WeatherItems", "Minst");
            DropColumn("dbo.WeatherItems", "Max");
        }
        
        public override void Down()
        {
            AddColumn("dbo.WeatherItems", "Max", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.WeatherItems", "Minst", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.WeatherItems", "MaxTemp");
            DropColumn("dbo.WeatherItems", "MinstTemp");
        }
    }
}
