using RelationshipsTask.Entities;
using RelationshipsTask.ViewModel;
using Microsoft.AspNetCore.Mvc;
using RelationshipsTask.DAL;

namespace HomeTaskReletion.Controllers
{
    public class TestimonialController:Controller
    {
        readonly RelationsDbContext _context;
        public TestimonialController(RelationsDbContext context)
        {
            _context = context;
        }
        public IActionResult Detail(int id)
        {
            Testimonial testimonial = _context.Testimonials.Include(c => c.Profession).ToList().FirstOrDefault(x => x.Id == id);
            return View(testimonial);
        }
    }
}