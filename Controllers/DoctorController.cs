using Assignment3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment3.Controllers
{
    public class DoctorController : Controller
    {

        public IActionResult FeverCheck()
        {
            ViewBag.Message = FeverModel.PromptForTemperature();
            return View();
        }
        [HttpPost]
        public IActionResult FeverCheck(int temperature)
        {
            FeverModel fm = new FeverModel
            {
                Temperature = temperature
            };

            ViewBag.Message = fm.CheckFever(temperature);
            return View();
        }
    }
}





