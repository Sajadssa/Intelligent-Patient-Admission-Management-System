namespace IPAMS_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IPAMS_User_Login_BE2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.IPAMS_User_Login_BE", "AccessLevel", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.IPAMS_User_Login_BE", "AccessLevel", c => c.String());
        }
    }
}
