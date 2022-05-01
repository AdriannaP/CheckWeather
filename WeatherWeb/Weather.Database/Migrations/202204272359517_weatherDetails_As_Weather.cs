namespace Weather.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class weatherDetails_As_Weather : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.City", "Weather_Id", c => c.Int());
            CreateIndex("dbo.City", "Weather_Id");
            AddForeignKey("dbo.City", "Weather_Id", "dbo.WeatherDetails", "Id");
            DropColumn("dbo.City", "Weather");
        }
        
        public override void Down()
        {
            AddColumn("dbo.City", "Weather", c => c.String());
            DropForeignKey("dbo.City", "Weather_Id", "dbo.WeatherDetails");
            DropIndex("dbo.City", new[] { "Weather_Id" });
            DropColumn("dbo.City", "Weather_Id");
        }
    }
}
