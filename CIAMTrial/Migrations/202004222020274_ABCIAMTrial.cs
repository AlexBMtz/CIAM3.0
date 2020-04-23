namespace CIAMTrial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ABCIAMTrial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Centers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PhoneNumber = c.String(),
                        Address = c.String(),
                        ZipCode = c.String(),
                        ManagerEmployee = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeNumber = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.String(),
                        Address = c.String(),
                        ZipCode = c.String(),
                        Area = c.String(),
                        ImageUrl = c.String(),
                        Center_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Centers", t => t.Center_Id)
                .Index(t => t.Center_Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        Description = c.String(),
                        ProductTye = c.String(),
                        AvaliableQuantity = c.Double(nullable: false),
                        ProductQuality = c.String(),
                        Center_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Centers", t => t.Center_Id)
                .Index(t => t.Center_Id);
            
            CreateTable(
                "dbo.DonationDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DonorName = c.String(),
                        AdmissionDate = c.DateTime(nullable: false),
                        Quantity = c.Double(nullable: false),
                        DonationType = c.String(),
                        Donation_Id = c.Int(),
                        Product_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Donations", t => t.Donation_Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .Index(t => t.Donation_Id)
                .Index(t => t.Product_Id);
            
            CreateTable(
                "dbo.Donations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DonorName = c.String(),
                        ReceiverEmployee = c.String(),
                        ReceiverCenter = c.String(),
                        Donor_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Donors", t => t.Donor_Id)
                .Index(t => t.Donor_Id);
            
            CreateTable(
                "dbo.RequestDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Folio = c.Int(nullable: false),
                        DepatureTime = c.DateTime(nullable: false),
                        ProductQuantity = c.Int(nullable: false),
                        ProductName = c.String(),
                        Product_Id = c.Int(),
                        Request_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .ForeignKey("dbo.Requests", t => t.Request_Id)
                .Index(t => t.Product_Id)
                .Index(t => t.Request_Id);
            
            CreateTable(
                "dbo.Requests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Destination = c.String(),
                        ShippingClerk = c.String(),
                        Center_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Centers", t => t.Center_Id)
                .Index(t => t.Center_Id);
            
            CreateTable(
                "dbo.Donors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Donations", "Donor_Id", "dbo.Donors");
            DropForeignKey("dbo.Products", "Center_Id", "dbo.Centers");
            DropForeignKey("dbo.RequestDetails", "Request_Id", "dbo.Requests");
            DropForeignKey("dbo.Requests", "Center_Id", "dbo.Centers");
            DropForeignKey("dbo.RequestDetails", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.DonationDetails", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.DonationDetails", "Donation_Id", "dbo.Donations");
            DropForeignKey("dbo.Employees", "Center_Id", "dbo.Centers");
            DropIndex("dbo.Requests", new[] { "Center_Id" });
            DropIndex("dbo.RequestDetails", new[] { "Request_Id" });
            DropIndex("dbo.RequestDetails", new[] { "Product_Id" });
            DropIndex("dbo.Donations", new[] { "Donor_Id" });
            DropIndex("dbo.DonationDetails", new[] { "Product_Id" });
            DropIndex("dbo.DonationDetails", new[] { "Donation_Id" });
            DropIndex("dbo.Products", new[] { "Center_Id" });
            DropIndex("dbo.Employees", new[] { "Center_Id" });
            DropTable("dbo.Donors");
            DropTable("dbo.Requests");
            DropTable("dbo.RequestDetails");
            DropTable("dbo.Donations");
            DropTable("dbo.DonationDetails");
            DropTable("dbo.Products");
            DropTable("dbo.Employees");
            DropTable("dbo.Centers");
        }
    }
}
