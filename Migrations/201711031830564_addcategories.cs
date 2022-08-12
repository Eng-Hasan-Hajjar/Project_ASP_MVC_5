namespace mybroject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcategories : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        cat_name = c.String(nullable: false),
                        cat_description = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Categories");
        }
    }
}
