using Cascading.Data;
using Microsoft.AspNetCore.Mvc;

namespace Cascading.Controllers
{
    public class CascadeController : Controller
    {
        private readonly AddDb context;

        public CascadeController(AddDb Context)
        {
            context = Context;
        }
        public IActionResult Country()
        {
            var cot = context.countries.ToList();
            return Json(cot);
        }
        public IActionResult State(int id)
        {
            var st = context.states.Where(x => x.country.Id == id).ToList();
                return Json(st);
        }
        public IActionResult City(int id)
        {
            var ci = context.cities.Where(x => x.state.Id == id).ToList();
            return Json(ci);
        }
        public IActionResult CascadeDropdown()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
