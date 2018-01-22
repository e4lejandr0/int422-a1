using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace INT422A1.Migrations
{
    public partial class CreatePhoneTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                    name: "Phones",
                    columns: table => new 
                    {
                        Id = table.Column<Guid>(nullable: false),
                        PhoneName = table.Column<string>(nullable: false),
                        Manufacturer = table.Column<string>(nullable: false),
                        DateReleased = table.Column<DateTime>(nullable: false),
                        MSRP = table.Column<float>(nullable: false),
                        ScreenSize = table.Column<double>(nullable: false)
                    },
                    constraints: table => 
                    {
                        table.PrimaryKey("Phone_PK", el => el.Id);
                    });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Phones");

        }
    }
}
