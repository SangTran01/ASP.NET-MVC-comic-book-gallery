using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {

            var comicBook = new ComicBook();
            comicBook.SeriesTitle = "The Amazing Spider-Man";
            comicBook.IssueNumber = 700;
            comicBook.DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
            comicBook.Artists = new Artist[]
            {
                new Artist("Script", "Dan Slott"),
                new Artist("Pencils","Humberto Ramos"),
                new Artist("Inks","Victor Olazaba"),
                new Artist("Colors", "Edgar Delgado"),
                new Artist("Letters","Chris Eliopoulos")
            };

            return View(comicBook);
        }
    }
}