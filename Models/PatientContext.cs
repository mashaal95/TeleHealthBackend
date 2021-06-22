using Microsoft.EntityFrameworkCore;


namespace TelstraAPI.Models
{
    public class PatientContext : DbContext
    {
        public PatientContext(DbContextOptions<PatientContext> options) : base(options)
        { }

        public DbSet<Patient> Patient { get; set; }
    }
}