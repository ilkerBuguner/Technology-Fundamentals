using System;
using System.Collections.Generic;
using System.Linq;
using GameStore.Data;
using GameStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new GameStoreDbContext())
            {
                var gamesList = db.Games.ToList();
                return View(gamesList);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Game game)
        {
            using (var db = new GameStoreDbContext())
            {
                db.Games.Add(game);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new GameStoreDbContext())
            {
                var gameToEdit = db.Games.FirstOrDefault(x => x.Id == id);
                if (gameToEdit == null)
                {
                    return RedirectToAction("Index");
                }
                return View(gameToEdit);
            }
        }

        [HttpPost]
        public IActionResult Edit(Game game)
        {
            using (var db = new GameStoreDbContext())
            {
                var gameToEdit = db.Games.FirstOrDefault(x => x.Id == game.Id);
                gameToEdit.Name = game.Name;
                gameToEdit.Platform = game.Platform;
                gameToEdit.Dlc = game.Dlc;
                gameToEdit.Price = game.Price;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var db = new GameStoreDbContext())
            {
                Game gameToDelete = db.Games.FirstOrDefault(x => x.Id == id);
                if (gameToDelete == null)
                {
                    return RedirectToAction("Index");
                }
                return View(gameToDelete);
            }
        }

        [HttpPost]
        public IActionResult Delete(Game game)
        {
            using (var db = new GameStoreDbContext())
            {
                Game gameToDelete = db.Games.FirstOrDefault(x => x.Id == game.Id);
                db.Games.Remove(gameToDelete);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}