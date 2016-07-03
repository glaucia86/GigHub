using System;
using GigHub.Models;
using GigHub.ViewModels;
using System.Linq;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security.Provider;

namespace GigHub.Controllers
{
    public class GigsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GigsController()
        {
            _context = new ApplicationDbContext();
        }

        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new GigViewModel
            {
                Genres = _context.Genres.ToList()
            };

            return View(viewModel);
        }

        /* Action para poder enviar as informações do formulário "Adicionar Apresentação" */
        [Authorize]
        [HttpPost]
        public ActionResult Create(GigViewModel viewModel)
        {
            var gig = new Gig()
            {
                ArtistId = User.Identity.GetUserId(),
                DateTime = DateTime.Parse(string.Format("{0} {1}", viewModel.Date, viewModel.Time)),
                GenreId = viewModel.Genre,
                Venue = viewModel.Venue
            };

            _context.Gigs.Add(gig);
            _context.SaveChanges();

            /* o 'return' será o redirecionamento da página assim que o usuário clicar no botão 'Salvar' */
            return RedirectToAction("Index", "Home");
        }
    }
}