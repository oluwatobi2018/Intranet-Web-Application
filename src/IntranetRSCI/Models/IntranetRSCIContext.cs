using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace IntranetRSCI.Models
{
    public class IntranetRSCIContext : DbContext
    {
        public IntranetRSCIContext(DbContextOptions<IntranetRSCIContext> options) : base(options)
        { }

        public DbSet<TechLead> TechLeads { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
