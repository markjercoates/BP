using API.Domain;
using System.IO;
using System.Xml.Linq;
using static API.Domain.Constants;

namespace API.Data
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            //if (context.Sites.Any()) return;

            var sites = new List<Site>
            {
                new Site
                {
                    Id= 1,
                    Name = "Somerville Service Station",
                    Street = "827 YORK ROAD",
                    Town = "Leeds",
                    PostCode = "LS14 67AA"
                },
                new Site
                {
                    Id= 2,
                    Name = "Moortown Filling Station",
                    Street = "401 Harrogate ROAD",
                    Town = "Leeds",
                    PostCode = "LS17 6DJ",
                },
                new Site
                {
                    Id= 3,
                    Name = "Rosevill Road Station",
                    Street = "87 Roseville Road",
                    Town = "Leeds",
                    PostCode = "LS8 5DT",
                 },
                new Site
                {
                    Id= 4,
                    Name = "Harrogate Road Express",
                    Street = "Harrogate Road",
                    Town = "Leeds",
                    PostCode = "LS8 4LA",
                 }
            };

            await context.Sites.AddRangeAsync(sites);
            await context.SaveChangesAsync();

            var pumps = new List<Pump>
            {
                 new Pump
                 {
                            SiteId= 1,
                            Name = "Pump 1",
                            PricePerLitre = 137.8M,
                            Locked= true,
                            FuelType = FuelTypes.UNLEADED,
                 },
                  new Pump
                  {
                            SiteId= 1,
                            Name = "Pump 2",
                            PricePerLitre = 170.0M,
                            Locked= true,
                            FuelType = FuelTypes.SUPERUNLEADED,
                  },
                  new Pump
                  {
                            SiteId= 1,
                            Name = "Pump 3",
                            PricePerLitre = 138.8M,
                            Locked= true,
                            FuelType = FuelTypes.DIESAL,
                  },
                  new Pump
                  {
                            SiteId= 1,
                            Name = "Pump 4",
                            PricePerLitre = 202.5M,
                            Locked= true,
                            FuelType = FuelTypes.PREMIUMDIESAL,
                  },

                  new Pump
                 {
                            SiteId= 2,
                            Name = "Pump 1",
                            PricePerLitre = 136.8M,
                            Locked= true,
                            FuelType = FuelTypes.UNLEADED,
                 },
                  new Pump
                  {
                            SiteId= 2,
                            Name = "Pump 2",
                            PricePerLitre = 170.0M,
                            Locked= true,
                            FuelType = FuelTypes.SUPERUNLEADED,
                  },
                  new Pump
                  {
                            SiteId= 2,
                            Name = "Pump 3",
                            PricePerLitre = 138.9M,
                            Locked= true,
                            FuelType = FuelTypes.DIESAL,
                  },
                  new Pump
                  {
                            SiteId= 2,
                            Name = "Pump 4",
                            PricePerLitre = 200.5M,
                            Locked= true,
                            FuelType = FuelTypes.PREMIUMDIESAL,
                  },

                 new Pump
                 {
                            SiteId= 3,
                            Name = "Pump 1",
                            PricePerLitre = 135.8M,
                            Locked= true,
                            FuelType = FuelTypes.UNLEADED,
                 },
                  new Pump
                  {
                            SiteId= 3,
                            Name = "Pump 2",
                            PricePerLitre = 169.5M,
                            Locked= true,
                            FuelType = FuelTypes.SUPERUNLEADED,
                  },
                  new Pump
                  {
                            SiteId= 3,
                            Name = "Pump 3",
                            PricePerLitre = 139.9M,
                            Locked= true,
                            FuelType = FuelTypes.DIESAL,
                  },
                  new Pump
                  {
                            SiteId= 3,
                            Name = "Pump 4",
                            PricePerLitre = 201.5M,
                            Locked= true,
                            FuelType = FuelTypes.PREMIUMDIESAL,
                  },

                   new Pump
                 {
                            SiteId= 4,
                            Name = "Pump 1",
                            PricePerLitre = 133.8M,
                            Locked= true,
                            FuelType = FuelTypes.UNLEADED,
                 },
                  new Pump
                  {
                            SiteId= 4,
                            Name = "Pump 2",
                            PricePerLitre = 168.5M,
                            Locked= true,
                            FuelType = FuelTypes.SUPERUNLEADED,
                  },
            };

            await context.Pumps.AddRangeAsync(pumps);
            await context.SaveChangesAsync();
        }
    }
}
