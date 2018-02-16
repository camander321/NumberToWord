using Microsoft.AspNetCore.Mvc;
using NumbersToWords.Models;

namespace NumbersToWords.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View("Index");
    }

    [HttpPost("/")]
    public ActionResult Result()
    {
      return View("Result", NumberToWord.Convert(Request.Form["number"]));
    }
  }
}
