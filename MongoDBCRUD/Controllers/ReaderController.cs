using Microsoft.AspNetCore.Mvc;
using MongoDBCRUD.Interface;
using MongoDBCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDBCRUD.Controllers
{
    public class ReaderController : Controller
    {
        private readonly IQLTV _context;

        public ReaderController(IQLTV context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.GetAllReader());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePost(ReaderEntity readerData)
        {
            _context.Create(readerData);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(string Name)
        {
            var md = _context.GetReaderDetails(Name);
            return View(md);
        }
        [HttpPost]
        public IActionResult EditPost(string _id, ReaderEntity readerData)
        {
            _context.Update(_id, readerData);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(string Name)
        {
            var md = _context.GetReaderDetails(Name);
            return View(md);
         }
        public IActionResult Delete(string Name)
        {
            var md = _context.GetReaderDetails(Name);
            return View(md);
        }
        [HttpPost]
        public IActionResult DeletePost(string MADG, string TENDG, string id, string SODT)
        {
            _context.Delete(MADG, id, TENDG,SODT);
            return RedirectToAction("Index");
        }
    }
}
