namespace IPAMS_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IPAM_User_Security : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.IPAMS_User_Security",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Enable = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.IPAMS_User_Security");
        }
    }
}
