namespace Casgem_CodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_message_table1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Messages", "MessageName", c => c.String());
            AlterColumn("dbo.Messages", "MessageMail", c => c.String());
            AlterColumn("dbo.Messages", "MessageSubject", c => c.String());
            AlterColumn("dbo.Messages", "MessageDescription", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Messages", "MessageDescription", c => c.Int(nullable: false));
            AlterColumn("dbo.Messages", "MessageSubject", c => c.Int(nullable: false));
            AlterColumn("dbo.Messages", "MessageMail", c => c.Int(nullable: false));
            AlterColumn("dbo.Messages", "MessageName", c => c.Int(nullable: false));
        }
    }
}
