using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ABCFoodCateringProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ABCFoodCateringProject.Models
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ABCFoodCateringProject.Models.Customer> Customer { get; set; }

        public DbSet<ABCFoodCateringProject.Models.Order> Order { get; set; }
    }
}
