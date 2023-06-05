using RelationshipsTask.Entities;

namespace RelationshipsTask.ViewModel
{
    public class RelationshipsVM
    {
        public List<Chef> Chefs { get; set; } = null!;
        public List<Testimonial> Testimonials { get; set; } = null!;
        public List<Profession> Professions { get; set; } = null!;
        public List<ChefSocialMedia> ChefSocialMedias { get; set; } = null!;
    }
}
