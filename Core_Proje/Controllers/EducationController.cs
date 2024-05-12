using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class EducationController : Controller
    {
        EducationManager educationController = new EducationManager(new EfEducationDal());
        public IActionResult Index()
        {
            var values = educationController.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddEducation()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddEducation(Education education)
        {
            educationController.TAdd(education);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteEducation(int id)
        {
            var value = educationController.TGetByID(id);
            educationController.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditEducation(int id)
        {
            var value = educationController.TGetByID(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult EditEducation(Education education)
        {
            educationController.TUpdate(education);
            return RedirectToAction("Index");
        }
    }
}
