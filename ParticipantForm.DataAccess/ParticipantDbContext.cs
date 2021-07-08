using Microsoft.EntityFrameworkCore;
using ParticipantForm.Entities.Model;

namespace ParticipantForm.DataAccess
{
    public class ParticipantDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string connectionString = "Server=VODVIL\\SQLEXPRESS;Database=HotelDb;Integrated Security=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }
        public DbSet<Participant> Participant { get; set; }
    }
}