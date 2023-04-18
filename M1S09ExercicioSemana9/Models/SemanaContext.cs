using Microsoft.EntityFrameworkCore;

namespace M1S09ExercicioSemana9.Models
{
    public class SemanaContext :DbContext
    {
        public SemanaContext(DbContextOptions<SemanaContext> options) : base(options)
        {

        }

        public DbSet<SemanaModel> Semana { get; set; }
    }
}
