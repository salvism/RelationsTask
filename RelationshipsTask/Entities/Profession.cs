namespace RelationshipsTask.Entities
{
    public class Profession
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Chef> Chefs { get; set; }
        public ICollection<Testimonial> Testimonials { get; set; }
    }
}
