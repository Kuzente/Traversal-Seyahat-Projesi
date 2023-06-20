using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        IAppUserService _appUserService;

        public UserController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        public IActionResult Index()
        {
            var users = _appUserService.TGetList();
            return View(users);
        }
        public IActionResult DeleteUser(int id)
        {
            var user = _appUserService.TGetById(id);
            _appUserService.TDelete(user);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateUser(int id)
        {
            var user = _appUserService.TGetById(id);           
            return View(user);
        }
        [HttpPost]
        public IActionResult UpdateUser(AppUser appUser)
        {
            _appUserService.TUpdate(appUser);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult AddUser(int id)
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddUser(AppUser appUser)
        {
            _appUserService.TAdd(appUser);
            return RedirectToAction("Index");
        }
        public IActionResult CommentUser(int id)
        {
            _appUserService.TGetList();
            return View();
        }
        public IActionResult ReservationtUser(int id)
        {
            _appUserService.TGetList();
            return View();
        }
    }
}
