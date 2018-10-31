using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using online_Bookstore.Models;

namespace online_Bookstore.Controllers
{
    public class Book_InventoryController : Controller
    {
        private BookStoreEntities db = new BookStoreEntities();

        // GET: Book_Inventory
        public ActionResult Index()
        {
            var book_Inventory = db.Book_Inventory.Include(b => b.category);
            return View(book_Inventory.ToList());
        }

        // GET: Book_Inventory/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book_Inventory book_Inventory = db.Book_Inventory.Find(id);
            if (book_Inventory == null)
            {
                return HttpNotFound();
            }
            return View(book_Inventory);
        }

        // GET: Book_Inventory/Create
        public ActionResult Create()
        {
            ViewBag.category_id = new SelectList(db.categories, "category_id", "category_name");
            return View();
        }

        // POST: Book_Inventory/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "book_id,book_title,book_author,book_descreption,price,book_img,category_id")] Book_Inventory book_Inventory)
        {
            if (ModelState.IsValid)
            {
                db.Book_Inventory.Add(book_Inventory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.category_id = new SelectList(db.categories, "category_id", "category_name", book_Inventory.category_id);
            return View(book_Inventory);
        }

        // GET: Book_Inventory/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book_Inventory book_Inventory = db.Book_Inventory.Find(id);
            if (book_Inventory == null)
            {
                return HttpNotFound();
            }
            ViewBag.category_id = new SelectList(db.categories, "category_id", "category_name", book_Inventory.category_id);
            return View(book_Inventory);
        }

        // POST: Book_Inventory/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "book_id,book_title,book_author,book_descreption,price,book_img,category_id")] Book_Inventory book_Inventory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(book_Inventory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.category_id = new SelectList(db.categories, "category_id", "category_name", book_Inventory.category_id);
            return View(book_Inventory);
        }

        // GET: Book_Inventory/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book_Inventory book_Inventory = db.Book_Inventory.Find(id);
            if (book_Inventory == null)
            {
                return HttpNotFound();
            }
            return View(book_Inventory);
        }

        // POST: Book_Inventory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Book_Inventory book_Inventory = db.Book_Inventory.Find(id);
            db.Book_Inventory.Remove(book_Inventory);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
