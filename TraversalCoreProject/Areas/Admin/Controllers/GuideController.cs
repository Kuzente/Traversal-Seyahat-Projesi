using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class GuideController : Controller
    {
        private readonly IGuideService _guideService;

        public GuideController(IGuideService guideService)
        {
            _guideService = guideService;
        }

        public IActionResult Index()
        {
            var values = _guideService.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddGuide()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult AddGuide(Guide guide)
        {
            GuideValidator guidevalitator = new GuideValidator();
            ValidationResult validationResult = guidevalitator.Validate(guide);
            if (validationResult.IsValid)
            {
                _guideService.TAdd(guide);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
            
        }
        [HttpGet]
        public IActionResult UpdateGuide(int id)
        {
            var value = _guideService.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateGuide(Guide guide)
        {
            
            GuideValidator guidevalitator = new GuideValidator();
            ValidationResult validationResult = guidevalitator.Validate(guide);
            if (validationResult.IsValid)
            {
                _guideService.TUpdate(guide);
                return RedirectToAction("Index");
            }
            else
            {
                foreach(var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
                return View(guide);
            }          
        }
        [HttpGet]
        public IActionResult DeleteGuide(int id)
        {
            var value = _guideService.TGetById(id);
            _guideService.TDelete(value);
            return RedirectToAction("Index");
        }
        public IActionResult ChangeToTrue(int id )
        {
            _guideService.ChangeToTrueByGuide(id);
            return RedirectToAction("Index");
        }
        public IActionResult ChangeToFalse(int id)
        {
            _guideService.ChangeToFalseByGuide(id);
            return RedirectToAction("Index");
        }
    }
}
