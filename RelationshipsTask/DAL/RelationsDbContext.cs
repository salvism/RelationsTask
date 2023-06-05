using System.Collections.Generic;

namespace RelationshipsTask.DAL
{
    public class RelationsDbContext:DbContext
    {
        public RelationsDbContext(DbContextOptions<RelationsDbContext> options):base(options)
        {

        }
        public DbSet<Chef> Chefs { get; set; }
        public DbSet<ChefSocialMedia> SocialMedias { get; set; }
        public DbSet<Profession> Professions { get; set; }
        public DbSet<Testemonial> Testimonials { get; set; }
    }
}
