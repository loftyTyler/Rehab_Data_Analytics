using Microsoft.EntityFrameworkCore;
using RehabDataProject.Models;

namespace RehabDataProject.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Patient_Info> Patients_Info { get; set; }
    }
}
