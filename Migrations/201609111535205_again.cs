namespace review_box.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class again : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ReviewModels",
                c => new
                    {
                        RecordNum = c.Int(nullable: false, identity: true),
                        Topic = c.String(),
                        Suggestion = c.String(),
                    })
                .PrimaryKey(t => t.RecordNum);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ReviewModels");
        }
    }
}
