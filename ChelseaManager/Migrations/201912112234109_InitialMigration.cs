namespace ChelseaManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Coaches",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 250),
                        LastName = c.String(nullable: false),
                        CoachRoleID = c.Int(nullable: false),
                        Birthdate = c.DateTime(nullable: false),
                        CountryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CoachRoles", t => t.CoachRoleID, cascadeDelete: true)
                .ForeignKey("dbo.Countries", t => t.CountryID, cascadeDelete: true)
                .Index(t => t.CoachRoleID)
                .Index(t => t.CountryID);
            
            CreateTable(
                "dbo.CoachRoles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Role = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 250),
                        LastName = c.String(nullable: false),
                        PositionID = c.Int(nullable: false),
                        Birthdate = c.DateTime(nullable: false),
                        CountryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Countries", t => t.CountryID, cascadeDelete: true)
                .ForeignKey("dbo.Positions", t => t.PositionID, cascadeDelete: true)
                .Index(t => t.PositionID)
                .Index(t => t.CountryID);
            
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PositionName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Players", "PositionID", "dbo.Positions");
            DropForeignKey("dbo.Players", "CountryID", "dbo.Countries");
            DropForeignKey("dbo.Coaches", "CountryID", "dbo.Countries");
            DropForeignKey("dbo.Coaches", "CoachRoleID", "dbo.CoachRoles");
            DropIndex("dbo.Players", new[] { "CountryID" });
            DropIndex("dbo.Players", new[] { "PositionID" });
            DropIndex("dbo.Coaches", new[] { "CountryID" });
            DropIndex("dbo.Coaches", new[] { "CoachRoleID" });
            DropTable("dbo.Positions");
            DropTable("dbo.Players");
            DropTable("dbo.Countries");
            DropTable("dbo.CoachRoles");
            DropTable("dbo.Coaches");
        }
    }
}
