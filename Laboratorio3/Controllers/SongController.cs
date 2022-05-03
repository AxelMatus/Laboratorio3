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
            var songs = GetListOfSongs();
            ViewBag.MainTitle = "My favorite song";
            return View(songs);
        }

        private List<SongModel> GetListOfSongs()
        {
            List<SongModel> songs = new List<SongModel>();
            songs.Add(new SongModel
            {
                Id = 1,
                Name = "Midnight City",
                Artist = "M83",
                Album = "Hurry Up, We're Dreaming",
                Genre = "Alternativa",
                ReleasedDate = new DateTime(2011, 10, 18)
            }) ;
            return songs;
        }
    }
}
