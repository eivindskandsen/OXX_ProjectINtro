using Microsoft.AspNetCore.Mvc;
using OXX_ProjectINtro.Models;
using OXX_ProjectINtro.ViewModels;

namespace OXX_ProjectINtro.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository=pieRepository;
        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PiesOfTheWeek = _pieRepository.PiesOfTheWeek
            };
            return View(homeViewModel);
        }
    }
}
