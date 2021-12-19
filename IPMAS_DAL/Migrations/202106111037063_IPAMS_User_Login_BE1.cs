namespace IPAMS_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IPAMS_User_Login_BE1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.IPAMS_User_Login_BE", "AccessLevel", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.IPAMS_User_Login_BE", "AccessLevel");
        }
    }
}
