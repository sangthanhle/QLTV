using Microsoft.AspNetCore.Mvc;
using MongoDBCRUD.Interface;
using MongoDBCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDBCRUD.Controllers
{
    public class TheLoaiController : Controller
    {
        private readonly IQLTV _context;

        public TheLoaiController(IQLTV context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.GetAllTheLoai());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePost(TheLoaiEntity theloaiData)
        {
            _context.Create(theloaiData);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(string Name)
        {
            var md = _context.GetTheLoaiDetails(Name);
            return View(md);
        }
        [HttpPost]
        public IActionResult EditPost(string _id, TheLoaiEntity theloaiData)
        {
            _context.Update(_id, theloaiData);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(string Name)
        {
            var md = _context.GetTheLoaiDetails(Name);
            return View(md);
        }
        [HttpGet]
        public IActionResult Delete(string Name)
        {
            var md = _context.GetTheLoaiDetails(Name);
            return View(md);
        }
        [HttpPost]
        public IActionResult DeletePost(string MATHELOAI, string TENTHELOAI, string id, string SODT, string TEN)
        {
            _context.Delete(id, MATHELOAI, TENTHELOAI,"","");
            return RedirectToAction("Index");
        }
    }
}

