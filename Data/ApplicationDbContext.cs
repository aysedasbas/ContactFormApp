using ContactFormApp2.Models;
using System.Data.Entity;

namespace ContactFormApp2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<ContactForm> ContactForms { get; set; }

        public ApplicationDbContext() : base("name=Contact")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ContactForm>().ToTable("ContactForm", "dbo");
        }
    }
}
