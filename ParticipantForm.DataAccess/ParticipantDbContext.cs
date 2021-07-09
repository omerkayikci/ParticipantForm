using Microsoft.EntityFrameworkCore;
using ParticipantForm.Entities.Model;

namespace ParticipantForm.DataAccess
{
    public class ParticipantDbContext : DbContext
    {
        public ParticipantDbContext(DbContextOptions<ParticipantDbContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }

        public DbSet<Participant> Participant { get; set; }
    }
}