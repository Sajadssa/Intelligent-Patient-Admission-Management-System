﻿namespace IPAMS_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IPAMS_Admission_Crud_BE3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.IPAMS_Admission_Crud_BE", "Time", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.IPAMS_Admission_Crud_BE", "Time");
        }
    }
}
