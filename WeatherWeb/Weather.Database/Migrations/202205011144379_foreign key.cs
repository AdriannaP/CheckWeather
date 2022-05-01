namespace Weather.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class foreignkey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.City", "Weather_Id", "dbo.WeatherDetails");
            DropIndex("dbo.City", new[] { "Weather_Id" });
            RenameColumn(table: "dbo.City", name: "Weather_Id", newName: "WeatherDetailsId");
            AlterColumn("dbo.City", "WeatherDetailsId", c => c.Int(nullable: false));
            CreateIndex("dbo.City", "WeatherDetailsId");
            AddForeignKey("dbo.City", "WeatherDetailsId", "dbo.WeatherDetails", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.City", "WeatherDetailsId", "dbo.WeatherDetails");
            DropIndex("dbo.City", new[] { "WeatherDetailsId" });
            AlterColumn("dbo.City", "WeatherDetailsId", c => c.Int());
            RenameColumn(table: "dbo.City", name: "WeatherDetailsId", newName: "Weather_Id");
            CreateIndex("dbo.City", "Weather_Id");
            AddForeignKey("dbo.City", "Weather_Id", "dbo.WeatherDetails", "Id");
        }
    }
}
