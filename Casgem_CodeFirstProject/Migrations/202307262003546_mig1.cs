namespace Casgem_CodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abouts",
                c => new
                    {
                        AboutID = c.Int(nullable: false, identity: true),
                        AboutName = c.String(),
                        AboutSurname = c.String(),
                        AboutPhone = c.String(),
                        AboutMail = c.String(),
                        AboutSubject = c.String(),
                        AboutAddress = c.String(),
                    })
                .PrimaryKey(t => t.AboutID);
            
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.AdminID);
            
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        BookingID = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(),
                        Destination = c.String(),
                        Duration = c.String(),
                        Mail = c.String(),
                        BokingDate = c.DateTime(nullable: false),
                        BokingStatus = c.String(),
                    })
                .PrimaryKey(t => t.BookingID);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ContactID = c.Int(nullable: false, identity: true),
                        ContactNameSurname = c.String(),
                        Mail = c.String(),
                        Subject = c.String(),
                        Message = c.String(),
                        MessageDate = c.String(),
                    })
                .PrimaryKey(t => t.ContactID);
            
            CreateTable(
                "dbo.Destinations",
                c => new
                    {
                        DestinationID = c.Int(nullable: false, identity: true),
                        DestinationName = c.String(),
                        DayNight = c.String(),
                        Capacity = c.String(),
                        Description = c.String(),
                        Price = c.String(),
                        ImageUrl = c.String(),
                        status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.DestinationID);
            
            CreateTable(
                "dbo.Guides",
                c => new
                    {
                        GuideID = c.Int(nullable: false, identity: true),
                        GuideName = c.String(),
                        GuideTitle = c.String(),
                        GuideImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.GuideID);
            
            CreateTable(
                "dbo.SocialMedias",
                c => new
                    {
                        SocialMediaID = c.Int(nullable: false, identity: true),
                        SocialMediaName = c.String(),
                        SocialMediaUrl = c.String(),
                        GuideID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SocialMediaID)
                .ForeignKey("dbo.Guides", t => t.GuideID, cascadeDelete: true)
                .Index(t => t.GuideID);
            
            CreateTable(
                "dbo.Holidays",
                c => new
                    {
                        HolidayID = c.Int(nullable: false, identity: true),
                        HolidayName = c.String(),
                        HolidayDescription = c.String(),
                        HolidayImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.HolidayID);
            
            CreateTable(
                "dbo.Personels",
                c => new
                    {
                        PersonelID = c.Int(nullable: false, identity: true),
                        PersonelName = c.String(),
                        PersonelJob = c.String(),
                        PersonelImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.PersonelID);
            
            CreateTable(
                "dbo.PhotoGaleries",
                c => new
                    {
                        PhotoGaleryID = c.Int(nullable: false, identity: true),
                        PhotoGaleryName = c.String(),
                        PhotoGaleryDescription = c.String(),
                    })
                .PrimaryKey(t => t.PhotoGaleryID);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        ServiceID = c.Int(nullable: false, identity: true),
                        ServiceName = c.String(),
                        ServiceDescription = c.String(),
                        ServiceImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.ServiceID);
            
            CreateTable(
                "dbo.Trips",
                c => new
                    {
                        TripID = c.Int(nullable: false, identity: true),
                        TripName = c.String(),
                        TripDescription = c.String(),
                        TripImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.TripID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SocialMedias", "GuideID", "dbo.Guides");
            DropIndex("dbo.SocialMedias", new[] { "GuideID" });
            DropTable("dbo.Trips");
            DropTable("dbo.Services");
            DropTable("dbo.PhotoGaleries");
            DropTable("dbo.Personels");
            DropTable("dbo.Holidays");
            DropTable("dbo.SocialMedias");
            DropTable("dbo.Guides");
            DropTable("dbo.Destinations");
            DropTable("dbo.Contacts");
            DropTable("dbo.Bookings");
            DropTable("dbo.Admins");
            DropTable("dbo.Abouts");
        }
    }
}
