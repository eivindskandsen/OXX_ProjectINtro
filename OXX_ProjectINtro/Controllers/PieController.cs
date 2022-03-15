using Microsoft.AspNetCore.Mvc;
using OXX_ProjectINtro.Models;
using OXX_ProjectINtro.ViewModels;

namespace OXX_ProjectINtro.Controllers
{
    
        public class PieController : Controller
        {
            private readonly IPieRepository _pieRepository;
            private readonly ICategoryRepository _categoryRepository;

            public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
            {
                _pieRepository = pieRepository;
                _categoryRepository = categoryRepository;
            }

            // GET: /<controller>/
            public IActionResult List()
            {
                //ViewBag.CurrentCategory = "Cheese cakes";

                //return View(_pieRepository.AllPies);
                PiesListViewModel piesListViewModel = new PiesListViewModel();
                piesListViewModel.Pies = _pieRepository.AllPies;

                piesListViewModel.CurrentCategory = "Cheese cakes";
                return View(piesListViewModel);
            }
        }
    
}
