﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vidly.Migrations
{
    public partial class UpdateMembershipTypeWithNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE MembershipType SET Name = 'Pay as You Go' WHERE Id = 1;");
            migrationBuilder.Sql("UPDATE MembershipType SET Name = 'Monthly', DurationInMonths = 1 WHERE Id = 2;");
            migrationBuilder.Sql("UPDATE MembershipType SET Name = 'Quarterly' WHERE Id = 3;");
            migrationBuilder.Sql("UPDATE MembershipType SET Name = 'Yearly' WHERE Id = 4;");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}

