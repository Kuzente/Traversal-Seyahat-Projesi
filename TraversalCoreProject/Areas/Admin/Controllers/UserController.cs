using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class UserController : Controller
    {
        private readonly IAppUserService _appUserService;
        private readonly IReservationService _reservationService;

        public UserController(IAppUserService appUserService, IReservationService reservationService)
        {
            _appUserService = appUserService;
            _reservationService = reservationService;
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
        [HttpGet]
        public IActionResult ReservationUser(int id)
        {
           var values = _reservationService.GetListWithReservationByAccepted(id); 
            return View(values);
        }
    }
}
