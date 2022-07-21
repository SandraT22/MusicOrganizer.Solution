using Microsoft.AspNetCore.Mvc;
using MusicOrganizer.Models;
using System.Collections.Generic;

namespace MusicOrganizer.Controllers
{
  public class RecordsController : Controller
  {
    [HttpPost("/records")]
    public ActionResult Create(string recordTitle)
    {
      Record newRecord = new Record(recordTitle);
      return RedirectToAction("Index");
    }

    [HttpGet("/records")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/records/new")]
    public ActionResult New()
    {
      return View();
    }
  }
}