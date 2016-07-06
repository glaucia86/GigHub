using System.Linq;
using System.Web.Mvc;
using GigHub.Models;
using Microsoft.AspNet.Identity;

namespace GigHub.Controllers
{
    public class FolloweesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FolloweesController()
        {
           _context = new ApplicationDbContext(); 
        }

        /* Método responsável em listar quais artistas o usuário que está logrado no sistema está seguindo */
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();
            var artists = _context.Followings
                .Where(f => f.FolloweeId == userId)
                .Select(f => f.Followee)
                .ToList();

            return View(artists);
        }
    }
}