namespace IPAMS_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IPAMS_Admission_Crud_BE4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.IPAMS_Admission_Crud_BE", "Amount_Discount", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.IPAMS_Admission_Crud_BE", "Amount_Discount");
        }
    }
}
