﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Data;
using Library.Models;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class LibraryController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new LibraryDbContext())
            {
                var allBooks = db.Books.ToList();
                return View(allBooks);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            using (var db = new LibraryDbContext())
            {
                db.Books.Add(book);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new LibraryDbContext())
            {
                var bookToEdit = db.Books.FirstOrDefault(x => x.Id == id);
                if (bookToEdit == null)
                {
                    return RedirectToAction("Index");
                }
                return View(bookToEdit);
            }
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            using (var db = new LibraryDbContext())
            {
                var bookToEdit = db.Books.FirstOrDefault(x => x.Id == book.Id);
                bookToEdit.Title = book.Title;
                bookToEdit.Author = book.Author;
                bookToEdit.Price = book.Price;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var db = new LibraryDbContext())
            {
                var bookDetails = db.Books.FirstOrDefault(x => x.Id == id);
                if (bookDetails == null)
                {
                    return RedirectToAction("Index");
                }
                return View(bookDetails);
            }
        }

        [HttpPost]
        public IActionResult Delete(Book book)
        {
            using (var db = new LibraryDbContext())
            {
                var bookToDelete = db.Books.FirstOrDefault(x => x.Id == book.Id);
                //if (bookToDelete == null)
                //{
                //    return RedirectToAction("Index");
                //}
                db.Books.Remove(bookToDelete);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}