using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBookController: Controller
    {
        public ActionResult Detail()
        {
            ViewBag.SeriesTitle = "The amazing Spider Man";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>Final issue! Witness the final hour";
            ViewBag.Artists = new string[]
            {
                    "Script: Dan Slott",
                    "Pencils: Humberto Ramos",
                    "Inks: Victor Olazaba",
                    "Colors: Edgar Delgado",
                    "Letters: Chris Eliopoulos"
            };
        
            return View();     
        }
    }
}