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
            string[] Manufacturers = new string[] { "Samsung", "Apple", "Huawei",
                                                    "Google" , "HTC"  , "Blu",
                                                    "Xiaomi" , "LeEco", "Sony" };
            string[] Models = new string[] { "Xperia", "Redmi Note 3", "Pixel",
                                             "Pixel 2", "Pixel XL", "iPhone 7",
                                             "iPhone X", "P8", "Mate 9" }; 
            Random rnd = new Random();
            
            Func<float, float, float> GenPrice = (float min, float max) => {
                return (float)rnd.NextDouble() * (max - min) + min;
            };
            for(int i = 0; i < 100; ++i) {
                db.Add(new Phone{
                        Id = Guid.NewGuid(),
                        PhoneName = Models[rnd.Next(Models.Length)],
                        Manufacturer = Manufacturers[rnd.Next(Manufacturers.Length)],
                        MSRP = GenPrice(99.99f, 1999.99f),
                        ScreenSize = GenPrice(4.0f, 7.0f),
                        DateReleased = new DateTime(rnd.Next(2012, 2018), rnd.Next(1, 12), rnd.Next(1, 28))
                });
            }
            db.SaveChanges();
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
