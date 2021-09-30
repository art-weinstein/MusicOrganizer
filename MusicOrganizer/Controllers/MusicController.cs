using Microsoft.AspNetCore.Mvc;
using MusicOrganizer.Models;
using System.Collections.Generic;

namespace MusicOrganizer.Controllers
{
  public class MusicController : Controller
  {
    [HttpGet("/music")]
    public ActionResult Index()
    {
      List<Disc> allDiscs = Disc.GetAll();
      return View(allDiscs);
    }

    [HttpGet("/music/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/music")]
    public ActionResult Create(string discArtist, string discGenre)
    {
      Disc myDisc = new Disc(discArtist, discGenre);
      return RedirectToAction("Index");
    }

    [HttpGet("/music/{Id}")]
    public ActionResult Show(int Id)
    {
      Disc disc = Disc.Find(Id);
      return View(disc);
    }
  }
}