using Microsoft.EntityFrameworkCore;
using StudentAdminPortal.API.DomainModels;

namespace StudentAdminPortal.API.DataModels
{
    public class StudentAdminContext : DbContext
    {
        public StudentAdminContext(DbContextOptions<StudentAdminContext> options): base(options)
        {
            
        }
        
        public DbSet<Student> Student { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<CLaim> Claims { get; set; }
       /* protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
       */
    }
}
