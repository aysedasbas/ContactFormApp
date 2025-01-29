using ContactFormApp2.Models;
using System.Data.Entity;

namespace ContactFormApp2.Data
{
    public class ApplicationDbContext : DbContext
    {
        // Veritabanındaki tabloları burada tanımlayın
        public DbSet<ContactForm> ContactForms { get; set; }

        public ApplicationDbContext() : base("DefaultConnection")
        {
        }
    }
}
