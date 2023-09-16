using Microsoft.AspNetCore.Mvc;
using MongoDBCRUD.Interface;
using MongoDBCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDBCRUD.Controllers
{
    public class BookController : Controller
    {
        private readonly IQLTV _context;

        public BookController(IQLTV context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.GetAllBook());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePost(BookEntity bookdata)
        {
            _context.Create(bookdata);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(string Name)
        {
            var md = _context.GetBookDetails(Name);
            return View(md);
        }
        [HttpPost]
        public IActionResult EditPost(string _id ,BookEntity bookdata)
        {
            _context.Update(_id,bookdata);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(string Name)
        {
            var md = _context.GetBookDetails(Name);
            return View(md);
        }
        [HttpGet]
        public IActionResult Delete(string Name)
        {
            var md = _context.GetBookDetails(Name);
            return View(md);
        }
        [HttpPost]
        public IActionResult DeletePost(string Name)
        {
             _context.Delete(Name);
            return RedirectToAction("Index");
        }
    }
    }

