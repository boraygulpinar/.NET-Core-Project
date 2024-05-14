using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class MessageController : Controller
    {
        MessageManager _MessageManager = new MessageManager(new EfMessageDal());
        public IActionResult Index()
        {
            var values = _MessageManager.TGetList();
            return View(values);
        }
    }
}
