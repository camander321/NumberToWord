using Microsoft.AspNetCore.Mvc;
using NumbersToWords.Models;
using System.Collections.Generic;

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
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("num", Request.Form["number"]);
      model.Add("str", NumberToWord.Convert(Request.Form["number"]));
      return View("Result", model);
    }
  }
}
