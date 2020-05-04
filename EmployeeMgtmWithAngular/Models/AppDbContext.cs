using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMgtmWithAngular.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> contextOptions) :base(contextOptions)
        {

        }

        public DbSet<Employee> Employee{ get; set; }
    }
}
