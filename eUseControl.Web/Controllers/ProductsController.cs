using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using eUseControl.BusinessLogic.DBModel;
using eUseControl.Domain.Entities.Product;

namespace eUseControl.Web.Controllers
{
    public class ProductsController : Controller
    {
        private ProductContext db = new ProductContext();

        // GET: Products
        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }

        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DbProduct dbProduct = db.Products.Find(id);
            if (dbProduct == null)
            {
                return HttpNotFound();
            }
            return View(dbProduct);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Prod_Id,Prod_Name,Prod_Desc,Prod_Price,LastEditTime")] DbProduct dbProduct)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(dbProduct);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dbProduct);
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DbProduct dbProduct = db.Products.Find(id);
            if (dbProduct == null)
            {
                return HttpNotFound();
            }
            return View(dbProduct);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Prod_Id,Prod_Name,Prod_Desc,Prod_Price,LastEditTime")] DbProduct dbProduct)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dbProduct).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dbProduct);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DbProduct dbProduct = db.Products.Find(id);
            if (dbProduct == null)
            {
                return HttpNotFound();
            }
            return View(dbProduct);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DbProduct dbProduct = db.Products.Find(id);
            db.Products.Remove(dbProduct);
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
