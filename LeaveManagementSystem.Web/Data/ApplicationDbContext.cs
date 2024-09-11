using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementSystem.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        // DbSet's LeaveType is the class name and the property name (LeaveTypes) is the name of the table in the Database
        public DbSet<LeaveType> LeaveTypes { get; set; }
    }
}
