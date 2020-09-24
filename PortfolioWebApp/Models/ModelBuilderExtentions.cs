using Microsoft.EntityFrameworkCore;
using PortfolioWebApp.Models.Enteties;
using System;

namespace PortfolioWebApp.Models
{
    public static class ModelBuilderExtentions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Owner>().HasData(
              new Owner()
              {
                  Id = Guid.NewGuid(),
                  Name = "MohaNed Ghawar",
                  Description = "Photographer and Designer",
              }
              );
            modelBuilder.Entity<Contact>().HasData(
              new Contact()
              {
                  Id = Guid.NewGuid(),
                  Mail = "MohaNed@Gmail.com",
                  Phone = "002191234567888",
                  Facebook = "MohaNed Facebook",
                  Twitter = "MohaNed Twitter",
                  Instagram = "MohaNed Instagram",

              }
              );
        }
    }
}
