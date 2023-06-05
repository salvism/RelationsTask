using RelationshipsTask.Entities;
using RelationshipsTask.ViewModel;
using Microsoft.AspNetCore.Mvc;
using RelationshipsTask.DAL;

namespace RelationshipsTask.Controllers
{
    public class ChefController:Controller
    {
        readonly RelationsDbContext _context;

        public ChefController(RelationsDbContext context)
        {
            _context = context;
        }

        public IActionResult Detail(int id)
        {
            Chef chef = _context.Chefs.Include(c => c.ChefSocialMedia).Include(c => c.Profession).ToList().FirstOrDefault(x => x.Id == id);
            return View(chef);
        }
    }
}