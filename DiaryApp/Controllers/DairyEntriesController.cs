using DiaryApp.Data;
using DiaryApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DiaryApp.Controllers
{
    public class DairyEntriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DairyEntriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<DiaryEntry> entries = _context.DiaryEntries.ToList();
            return View(entries);
        }

        public IActionResult CreateEntry() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateEntry(DiaryEntry entry)
        {

            if (entry != null && entry.Title.Length < 3)
            {
                ModelState.AddModelError("Title", "Title too short");
            }

            if (ModelState.IsValid) {
                _context.DiaryEntries.Add(entry);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(entry);
        }

        [HttpGet]
        public IActionResult EditEntry(int? id) 
        {
            if (id == null || id == 0) {
                return NotFound();
            }

            DiaryEntry? diaryEntry = _context.DiaryEntries.Find(id);
            
            if (diaryEntry == null) 
            {
                return NotFound();
            }

            return View(diaryEntry);

        }

        [HttpPost]
        public IActionResult EditEntry(DiaryEntry entry)
        {

            if (entry != null && entry.Title.Length < 3)
            {
                ModelState.AddModelError("Title", "Title too short");
            }

            if (ModelState.IsValid)
            {
                _context.DiaryEntries.Update(entry);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(entry);
        }


        [HttpGet]
        public IActionResult DeleteEntry(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            DiaryEntry? diaryEntry = _context.DiaryEntries.Find(id);

            if (diaryEntry == null)
            {
                return NotFound();
            }

            return View(diaryEntry);

        }

        [HttpPost]
        public IActionResult DeleteEntry(DiaryEntry entry)
        {
           
            _context.DiaryEntries.Remove(entry);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
