using Microsoft.AspNetCore.Mvc;
using NumbersToWords.Models;

namespace NumbersToWords.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Form()
    {
      return View("Index", "This is a message from the controller");
    }
  }
}
