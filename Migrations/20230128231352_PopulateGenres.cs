using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vidly.Migrations
{
    public partial class PopulateGenres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Genre (Id, Name) values (1, 'Comedy')");
            migrationBuilder.Sql("INSERT INTO Genre (Id, Name) values (2, 'Action')");
            migrationBuilder.Sql("INSERT INTO Genre (Id, Name) values (3, 'Family')");
            migrationBuilder.Sql("INSERT INTO Genre (Id, Name) values (4, 'Romance')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
