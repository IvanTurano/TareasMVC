using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TareasMVC.Migrations
{
    /// <inheritdoc />
    public partial class AdminRol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"IF NOT EXISTS(SELECT Id FROM AspNetRoles Where Id = '464a19ed-a22c-4477-8a9f-2a9394ad13d1')
                                  BEGIN
                                        INSERT AspNetRoles(Id,[Name],[NormalizedName])
                                        VALUES('464a19ed-a22c-4477-8a9f-2a9394ad13d1','admin','ADMIN')
                                  END
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE AspNetRoles WHERE Id = '464a19ed-a22c-4477-8a9f-2a9394ad13d1'");
        }
    }
}
