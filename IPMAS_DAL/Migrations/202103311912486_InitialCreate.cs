namespace IPAMS_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.IPAMS_Admission_Crud_BE",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Type_Admission = c.String(),
                        Date_Time = c.String(),
                        Remark = c.String(),
                        IPAMS_HIC_id = c.Int(),
                        IPMAS_Doctor_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.IPAMS_Health_Insurance_Crud_BE", t => t.IPAMS_HIC_id)
                .ForeignKey("dbo.IPAMS_Doctors_Crud_BE", t => t.IPMAS_Doctor_id)
                .Index(t => t.IPAMS_HIC_id)
                .Index(t => t.IPMAS_Doctor_id);
            
            CreateTable(
                "dbo.IPAMS_Health_Insurance_Crud_BE",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Type_Hic = c.String(),
                        Amount_Discount = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.IPAMS_Doctors_Crud_BE",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Doctor_Name = c.String(),
                        Specialty = c.String(),
                        Level = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.IPAMS_Patient_Crud_BE",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Family = c.String(),
                        National_Code = c.Double(nullable: false),
                        Gender = c.String(),
                        Phone_No = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.IPAMS_User_Login_BE",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        User_Name = c.String(),
                        Password = c.String(),
                        ConifirmPassword = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IPAMS_Admission_Crud_BE", "IPMAS_Doctor_id", "dbo.IPAMS_Doctors_Crud_BE");
            DropForeignKey("dbo.IPAMS_Admission_Crud_BE", "IPAMS_HIC_id", "dbo.IPAMS_Health_Insurance_Crud_BE");
            DropIndex("dbo.IPAMS_Admission_Crud_BE", new[] { "IPMAS_Doctor_id" });
            DropIndex("dbo.IPAMS_Admission_Crud_BE", new[] { "IPAMS_HIC_id" });
            DropTable("dbo.IPAMS_User_Login_BE");
            DropTable("dbo.IPAMS_Patient_Crud_BE");
            DropTable("dbo.IPAMS_Doctors_Crud_BE");
            DropTable("dbo.IPAMS_Health_Insurance_Crud_BE");
            DropTable("dbo.IPAMS_Admission_Crud_BE");
        }
    }
}
