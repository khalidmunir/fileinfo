namespace FileVIew1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class db : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FileInfoes",
                c => new
                    {
                        FileID = c.Int(nullable: false, identity: true),
                        FileName = c.String(),
                        FilePath = c.String(),
                        Volume = c.String(),
                        Size = c.Int(nullable: false),
                        Ctime = c.String(),
                        Mtime = c.String(),
                        Atime = c.String(),
                        MD5 = c.String(),
                        SecurityClassification = c.String(),
                        BusinessClassification = c.String(),
                        Extension = c.String(),
                        MimeType = c.String(),
                        EmployeeNo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FileID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FileInfoes");
        }
    }
}
