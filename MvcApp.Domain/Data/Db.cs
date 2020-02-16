using System.Data.Entity;

namespace MvcApp.Models.Data
{
    public class Db : DbContext
    {
        static Db()
        {
            Database.SetInitializer<Db>(new ArticleInitializer());
        }
        public DbSet<Article> Articles { get; set; }
        public DbSet<ProfDTO> Profs { get; set; }
        public DbSet<Person> People { get; set; }

    }

}