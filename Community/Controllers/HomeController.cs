using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Community.Models;
using Microsoft.AspNetCore.Mvc;

namespace Community.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      return View(new Player { });
    }

    public IActionResult About()
    {
      ViewData["Message"] = "Your application description page.";

      return View();
    }

    public IActionResult Game(Player p)
    {
      if (ModelState.IsValid)
      {
        p.UserName = p.UserName.ToUpper();
        // Fetch more info from db
        return View(p);
      }
      else
      {
        return View("Index", p);
      }
    }

    public IActionResult Contact()
    {
      ViewData["Message"] = "Your contact page.";

      return View();
    }

    public IActionResult Error()
    {
      return View();
    }

    [HttpGet]
    public IActionResult Blocks(int num)
    {
      var r = new Random();
      var blocks = Enumerable.Range(0, Math.Max(0, num))
                             .Select(_ => new
                             {
                               x = r.Next(0, 600),
                               y = r.Next(0, 400),
                               w = r.Next(10, 50),
                               h = r.Next(10, 50),
                               c = $"#{r.Next(0x1000000):X6}"
                             })
                             .ToList();

      return Json(blocks);
    }

    [HttpGet]
    public IActionResult CityBlocks()
    {
      return Json(City.Blocks);
    }

    [HttpGet]
    public IActionResult Persons()
    {
      return Json(City.Persons);
    }
  }
}
