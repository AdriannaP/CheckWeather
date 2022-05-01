namespace Weather.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class weatherdetails : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WeatherDetails", "Clouds", c => c.Long(nullable: false));
            AddColumn("dbo.WeatherDetails", "Wind", c => c.Double(nullable: false));
            AddColumn("dbo.WeatherDetails", "Pressure", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.WeatherDetails", "Pressure");
            DropColumn("dbo.WeatherDetails", "Wind");
            DropColumn("dbo.WeatherDetails", "Clouds");
        }
    }
}
