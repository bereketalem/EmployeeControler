using EmployeeControler.Models;
using EmployeeControler.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace EmployeeControler.Controllers
{
    public class EmployeesController : Controller
    {
        private ApplicationDbContext _context;

        public EmployeesController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Create()
        {
            var ViewModel = new EmployeView
            {
                Workers = _context.Workers.ToList()
            };

            return View(ViewModel);
        }
    }
}