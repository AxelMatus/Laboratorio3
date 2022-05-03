using Laboratorio3.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio3.Controllers
{
    public class SongController : Controller
    {
        public IActionResult Index()
        {
            var song = GetFavoriteSong();
            ViewBag.MainTitle = "My favorite song";
            return View(song);
        }

        private SongModel GetFavoriteSong()
        {
            SongModel song = new SongModel();
            song.Id = 1;
            song.Name = "Midnight City";
            song.Artist = "M83";
            song.Album = "Hurry Up, We're Dreaming";
            song.Genre = "Alternativa";
            song.ReleasedDate = new DateTime(2011, 10, 18);

            return song;
        }
    }
}
