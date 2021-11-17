using Assignment3.GuessTheNumber.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment3.Controllers
{
    public class GuessNumberController : Controller
    {
        public IActionResult GuessNumberIndex()
        {
            GuessNumberModel guessNumberModel = new GuessNumberModel();
            guessNumberModel.GenerateRandomNumber();
            return View(guessNumberModel);
        }

        //      [ActionName(GuessNumberIndexProcessed)] (OverflowException?)
        public IActionResult GuessNumberIndex(GuessNumberModel guessNumberModel)
        {

            if (ModelState.IsValid)
            {
                guessNumberModel.ShowResult = true;
                var result = new Result();
                ViewBag.Result = result.GetResult(ref guessNumberModel);
            }
            return View(guessNumberModel);
        }
    }
}
