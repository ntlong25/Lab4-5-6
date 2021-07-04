namespace BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (1, 'CONG NGHE PHAN MEM')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (2, 'HE THONG THONG TIN')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (3, 'MANG MAY TINH')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (4, 'BAO MAT THONG TIN')");
        }
        
        public override void Down()
        {
        }
    }
}
