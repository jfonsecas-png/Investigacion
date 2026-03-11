using Microsoft.EntityFrameworkCore;
using ClinicSystem.DTO;

namespace ClinicSystem.DataAccess
{
    public class ClinicDbContext : DbContext
    {
        public ClinicDbContext(DbContextOptions<ClinicDbContext> options)
            : base(options)
        {
        }

        public DbSet<Doctor> Doctors { get; set; }
    }
}