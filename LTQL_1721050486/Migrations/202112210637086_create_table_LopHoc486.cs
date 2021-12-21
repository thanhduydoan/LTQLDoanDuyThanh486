namespace LTQL_1721050486.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_LopHoc486 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DDTSinhVien486",
                c => new
                    {
                        MaSinhVien = c.String(nullable: false, maxLength: 20),
                        HoTen = c.String(maxLength: 50),
                        MaLop = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaSinhVien)
                .ForeignKey("dbo.LopHoc486", t => t.MaLop, cascadeDelete: true)
                .Index(t => t.MaLop);
            
            CreateTable(
                "dbo.Logins",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 128),
                        password = c.String(),
                    })
                .PrimaryKey(t => t.UserName);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DDTSinhVien486", "MaLop", "dbo.LopHoc486");
            DropIndex("dbo.DDTSinhVien486", new[] { "MaLop" });
            DropTable("dbo.Logins");
            DropTable("dbo.DDTSinhVien486");
        }
    }
}
