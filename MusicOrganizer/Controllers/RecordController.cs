using Microsoft.AspNetCore.Mvc;
using MusicOrganizer.Models;
using System.Collections.Generic;

namespace MusicOrganizer.Controllers
{
  public class RecordController : Controller
  {
    [HttpPost("/record")]
    public ActionResult Create(string recordTitle)
    {
      Record newRecord = new Record(recordTitle);
      return RedirectToAction("Index");
    }

    [HttpGet("/record")]
    public ActionResult Index()
    {
      return View();
    }
  }
}