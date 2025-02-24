using System.Diagnostics;
using DOTNET_course.Data.Access.Repository.IRepository;
using DOTNET_course.Models;
using DOTNET_course.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace DOTNET_course.Areas.Customer.Controllers
{
   
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<Product> productList = _unitOfWork.ProductRepository.GetAll(IncludeProperties: "Category");
            return View(productList);
        }

        public IActionResult Details(int productId)
        {
            Product product = _unitOfWork.ProductRepository.Get(u => u.Id == productId, IncludeProperties: "Category");
            return View(product);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}