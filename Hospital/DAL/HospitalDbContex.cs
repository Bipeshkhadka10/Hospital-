using Hospital.model;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace Hospital.DAL
{
    public class HospitalDbContext:DbContext
    {
        public HospitalDbContext(DbContextOptions<HospitalDbContext> options) : base(options) 
        {
             
        }
        public DbSet<Doctor>Doctors { get; set; }
    }
} 
