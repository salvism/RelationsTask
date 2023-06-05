using Microsoft.AspNetCore.Mvc;
using RelationshipsTask.DAL;
using RelationshipsTask.Entities;
using RelationshipsTask.ViewModel;

namespace RelationshipsTask.Controllers
{
    public class HomeController:Controller
    {
        readonly RelationsDbContext _context;
        public HomeController(RelationsDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Chef> chefs = _context.Chefs.Include(c => c.ChefSocialMedia).Include(c => c.Profession).AsEnumerable();
            IEnumerable<Testimonial> testimonials = _context.Testimonials.Include(c => c.Profession).AsEnumerable();

            RelationshipsVM model = new()
            {
                Chefs = chefs,
                Testimonials = testimonials
            };

            return View(model);
        }
    }
}
