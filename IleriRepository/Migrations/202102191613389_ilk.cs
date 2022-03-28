namespace IleriRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ilk : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Egitim",
                c => new
                    {
                        EgitimId = c.Int(nullable: false, identity: true),
                        EgitimAd = c.String(),
                    })
                .PrimaryKey(t => t.EgitimId);
            
            CreateTable(
                "dbo.Personel",
                c => new
                    {
                        PersonelId = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Soyad = c.String(),
                        SehirId = c.Int(nullable: false),
                        EgitimId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PersonelId)
                .ForeignKey("dbo.Egitim", t => t.EgitimId, cascadeDelete: true)
                .ForeignKey("dbo.Sehir", t => t.SehirId, cascadeDelete: true)
                .Index(t => t.SehirId)
                .Index(t => t.EgitimId);
            
            CreateTable(
                "dbo.Sehir",
                c => new
                    {
                        SehirId = c.Int(nullable: false, identity: true),
                        SehirAd = c.String(),
                    })
                .PrimaryKey(t => t.SehirId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Personel", "SehirId", "dbo.Sehir");
            DropForeignKey("dbo.Personel", "EgitimId", "dbo.Egitim");
            DropIndex("dbo.Personel", new[] { "EgitimId" });
            DropIndex("dbo.Personel", new[] { "SehirId" });
            DropTable("dbo.Sehir");
            DropTable("dbo.Personel");
            DropTable("dbo.Egitim");
        }
    }
}
