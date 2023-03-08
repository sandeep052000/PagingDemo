using Microsoft.AspNetCore.Mvc;
using PagingDemo.DbLayer;
using PagingDemo.Models;
using System.Diagnostics;

namespace PagingDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DBContextPaging _dbcontext;

        public HomeController(ILogger<HomeController> logger,DBContextPaging _context)
        {
            _logger = logger;
            _dbcontext = _context;  
        }

        public IActionResult Index(int? pageNumber)
        {
            int pageSize = 5;
            return View(PaginatedList<CustomersEntity>.Create(_dbcontext.Customers.ToList(),pageNumber ?? 1,pageSize) );
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