using Microsoft.AspNetCore.Mvc;
using MongoDBCRUD.Interface;
using MongoDBCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDBCRUD.Controllers
{
    public class GiaHanController : Controller
    {
        private readonly IQLTV _context;

        public GiaHanController(IQLTV context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.GetAllGiaHan());
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatePost(GiaHanEntity giahandata)
        {
            _context.Create(giahandata);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(string Name)
        {
            var md = _context.GetGiaHanDetails(Name);
            return View(md);
        }
        [HttpPost]
        public IActionResult EditPost(string _id, GiaHanEntity giahandata)
        {
            _context.Update(_id, giahandata);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(string Name)
        {
            var md = _context.GetGiaHanDetails(Name);
            return View(md);
        }
        [HttpGet]
        public IActionResult Delete(string Name)
        {
            var md = _context.GetGiaHanDetails(Name);
            return View(md);
        }
        [HttpPost]
        public IActionResult DeletePost(string Name , string TENDG)
        {
            _context.Delete(Name, TENDG);
            return RedirectToAction("Index");
        }
    }
}
