using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

using INT422A1.Models;

namespace INT422A1.Migrations
{
    public partial class SeedPhones : Migration
    {
        private static PhoneContext db = new PhoneContext();
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            for(int i = 0; i < 100; ++i) {
                db.Add(new Phone{ Id = Guid.NewGuid(), PhoneName = "Q10", Manufacturer = "BlackBerry", MSRP = 599.99f, ScreenSize = 5.75, DateReleased = new DateTime(2012, 07, 21) });
            }
            db.SaveChanges();
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
