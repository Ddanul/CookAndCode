﻿using Cookware.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookware.Data
{
    public class CookwareDBContext : DbContext
    {
        public CookwareDBContext(DbContextOptions<CookwareDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ID = 1,
                    Sku = "305361728",
                    Name = "Pancakebot Pancake Printer Griddle",
                    Price = 199.99M,
                    Description = "The Pancake Bot is the world’s first food printer capable of printing pancakes by automatically dispensing batter directly onto a griddle. Pancake designs can be loaded onto the Pancake Bot via SD card. Users can make their own pancake designs with the included software or browse through our online community that is updated with fun, new designs every week.",
                    Image = "https://images.homedepot-static.com/productImages/dc4da6a2-3be5-42f2-ab7a-23053eaca536/svn/black-dash-indoor-grills-pnkb01bk2-64_1000.jpg"
                },
                new Product
                {
                    ID = 2,
                    Sku = "1234567890",
                    Name = "Miito: Water Heater",
                    Price = 102.00M,
                    Description = "Simply fill your cup with water, place it on to the induction base, dip the metal rod into your cup, and turn the device on. The base will heat up the rod, thus heating the water surrounding the rod. The heat up time will vary depending on the size of your drinking vessel, but Miito can heat up a glass of water within 60 seconds or a kettle within in 2 and half minutes.",
                    Image = "https://odditymall.com/includes/content/miito-a-water-heater-that-heats-up-just-the-water-that-s-in-your-cup-thumb.jpg"
                },
                new Product
                {
                    ID = 3,
                    Sku = "1238647253",
                    Name = "Joseph Switch Scale",
                    Price = 36.87M,
                    Description = "This multi-functional digital scale is a versatile kitchen device which offers two options for weighing. You can either place items or bowls directly on to its top, or flip over the integrated lid to create a measuring bowl for weighing loose ingredients or liquids. Featuring an easy-to-read back-lit LCD display and touch-sensitive controls, it’s ready to weigh both liquids and dry foods in the following units – gms, lbs, ozs, fl.ozs, mls up to a maximum capacity of 5kg/176.4 fl.oz/11lb/5000ml. A convenient ‘add and weigh’ function allows multiple ingredients to be weighed during recipe preparation and an auto power-off feature maximizes battery life. It also has non-slip silicone feet.",
                    Image = "https://secure.img1-fg.wfcdn.com/im/00744531/resize-h800%5Ecompr-r85/1570/15708322/Switch+Scale.jpg"
                },
                new Product
                {
                    ID = 4,
                    Sku = "19874278053",
                    Name = "Somabar Automated Bartender",
                    Price = 4995M,
                    Description = "Create your own menu from a list of 300 cocktails choices from the International Bartenders Association, mix any drink in 10 seconds and never leave a mess with automated cleaning.",
                    Image = "https://www.somabar.com/hs-fs/hubfs/LP%20Images/somabar-new-machine.png?t=1542147816232&width=935&name=somabar-new-machine.png"
                },
                new Product
                {
                    ID = 5,
                    Sku = "19874278053",
                    Name = "Hiku Smart Kitchen Button",
                    Price = 79.00M,
                    Description = "Hiku lives in your kitchen, scans barcodes and recognizes your voice – creating a shared shopping list on your phone so you always know what you need. Use the hiku shopping list app at the store – any store – and your list is always with you. Or connect hiku to online stores to make online shopping a breeze.",
                    Image = "https://static1.squarespace.com/static/51ffe599e4b08f2e358d388a/t/5a6bce718165f5e669c54397/1446508681698/?format=750w"
                },
                new Product
                {
                    ID = 6,
                    Sku = "12836924879",
                    Name = "Range Dial Grill Pro smart cooking thermometer",
                    Price = 119.95M,
                    Description = "Range Dial is a versatile wireless cooking thermometer that can be used with or without your iPhone. Turn the machined stainless steel knob to set an alert, or use the iOS app for more control. ",
                    Image = "https://cdn.shopify.com/s/files/1/0103/5182/products/DSC_5124_grande_df13d5e4-bc6a-45e5-82d2-594c862dead6_1024x1024.jpg?v=1511328894"
                },
                new Product
                {
                    ID = 7,
                    Sku = "12836924879",
                    Name = "Quirky Refuel Smart Propane Tank Gauge",
                    Price = 65.00M,
                    Description = "Monitor your propane supply from anywhere, and receive alerts when it's running low. Position your grill in range of your Wi - Fi network and connect to the Wink App on your mobile device to receive alerts. Tapping the sensor displays an LED reading of the gas level when your smartphone isn't handy, Works with all grills with non - hanging propane tanks",
                    Image = "https://images-na.ssl-images-amazon.com/images/I/61iQ1zrE6eL._SL1001_.jpg"
                },
                new Product
                {
                    ID = 8,
                    Sku = "12836924879",
                    Name = "Nespresso Expert Espresso Machine",
                    Price = 329.99M,
                    Description = "Wake up to premium coffee right in your own home. No need to go to a coffee shop to get your morning fix. That is if you have this Nespresso Expert Espresso Machine. This coffee machine by De'Longhi lets you brew premium coffee in 4 convenient sizes: Americano, Espresso, Lungo, and Ristretto. As for the temperature settings, it has 3 distinct temperatures that you can choose from including medium, hot, and extra hot.All it takes is less than 30 seconds for your cup to be ready.It comes with a capsule testing pack, but after that, you had better get more Nepresso capsules because this is addicting!",
                    Image = "https://d3f8t323tq9ys5.cloudfront.net/uploads/2017/08/71g-omzSENL._SL1500_.jpg"
                },
                new Product
                {
                    ID = 9,
                    Sku = "12836924879",
                    Name = "Nespresso Expert Espresso Machine",
                    Price = 329.99M,
                    Description = "Wake up to premium coffee right in your own home. No need to go to a coffee shop to get your morning fix. That is if you have this Nespresso Expert Espresso Machine. This coffee machine by De'Longhi lets you brew premium coffee in 4 convenient sizes: Americano, Espresso, Lungo, and Ristretto. As for the temperature settings, it has 3 distinct temperatures that you can choose from including medium, hot, and extra hot.All it takes is less than 30 seconds for your cup to be ready.It comes with a capsule testing pack, but after that, you had better get more Nepresso capsules because this is addicting!",
                    Image = "https://d3f8t323tq9ys5.cloudfront.net/uploads/2017/08/71g-omzSENL._SL1500_.jpg"
                },
                new Product
                {
                    ID = 10,
                    Sku = "927348829849",
                    Name = "Vacuvita® Home Base One-Touch Vacuum Storage System",
                    Price = 299.99M,
                    Description = "The Vacuvita Home Base is a great way to store food on your kitchen countertop. Instead of taking up space in your cupboard or kitchen, this system vacuum seals its contents every single time it is closed. This means that you can reduce waste (because food will last much longer) and the associated app will also help you keep track of your stored foods so you know when it’s time to eat them. Never eat an unripe avocado again. It’s also perfect for travel, or for a chef on the go.",
                    Image = "https://d3f8t323tq9ys5.cloudfront.net/uploads/2016/06/product-58d758d281e47-Front-700x700.jpg"
                }
                );
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }
    }
}
