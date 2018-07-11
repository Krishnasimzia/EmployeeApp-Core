using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeAppcore.Models;

namespace EmployeeAppcore.Models
{
    public class EmployeeAppcoreContext : DbContext
    {
        public EmployeeAppcoreContext (DbContextOptions<EmployeeAppcoreContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeAppcore.Models.Employee> Employee { get; set; }

        public DbSet<EmployeeAppcore.Models.Department> Department { get; set; }

    }
}
