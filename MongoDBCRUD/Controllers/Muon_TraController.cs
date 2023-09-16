using Microsoft.AspNetCore.Mvc;
using MongoDBCRUD.Interface;
using MongoDBCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDBCRUD.Controllers
{
    public class Muon_TraController : Controller
    {
        private readonly IQLTV _context;

        public Muon_TraController(IQLTV context)    
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.GetAllMuon_Tra());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePost(Muon_Tra_Entity muontraData)
        {
            _context.Create(muontraData);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(string Name)
        {
            var md = _context.GetMuon_TraDetails(Name);
            return View(md);
        }
        [HttpPost]
        public IActionResult EditPost(string _id, Muon_Tra_Entity muontraData)
        {
            _context.Update(_id, muontraData);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(string Name)
        {
            var md = _context.GetMuon_TraDetails(Name);
            return View(md);
        }
        [HttpGet]
        public IActionResult Delete(string Name)
        {
            var md = _context.GetMuon_TraDetails(Name);
            return View(md);
        }
        [HttpPost]
        public IActionResult DeletePost(string Name , string id, string TENDG)
        {
            _context.Delete(Name, id, TENDG);
            return RedirectToAction("Index");
        }
        
    }
}

