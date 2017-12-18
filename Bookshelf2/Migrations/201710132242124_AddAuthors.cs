namespace Bookshelf2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAuthors : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "AuthorID", c => c.Int());
            CreateIndex("dbo.Books", "AuthorID");
            AddForeignKey("dbo.Books", "AuthorID", "dbo.Authors", "ID");
            DropColumn("dbo.Authors", "Books");
            DropColumn("dbo.Books", "Author");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "Author", c => c.String());
            AddColumn("dbo.Authors", "Books", c => c.String());
            DropForeignKey("dbo.Books", "AuthorID", "dbo.Authors");
            DropIndex("dbo.Books", new[] { "AuthorID" });
            DropColumn("dbo.Books", "AuthorID");
        }
    }
}
