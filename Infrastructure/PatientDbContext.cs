
using Microsoft.EntityFrameworkCore;
using Patient_Clinic1;
using Patients;

namespace Patient_Clinic1
{
    public class PatientDbcontext : DbContext
    {
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Injury> injuries { get; set; }
        public PatientDbcontext() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=" + Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Patients.db"));
        }
    }
}
