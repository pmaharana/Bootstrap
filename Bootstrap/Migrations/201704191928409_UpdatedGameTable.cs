namespace Bootstrap.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedGameTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Games", "Score", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Games", "Score", c => c.Int(nullable: false));
        }
    }
}
