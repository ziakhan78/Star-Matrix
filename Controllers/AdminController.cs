using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StarMatrix.Models;

namespace StarMatrix.Controllers
{
    public class AdminController : Controller
    {
        private readonly StarMatrixContext _context;

        public AdminController(StarMatrixContext context)
        {
            _context = context;
        }

        // GET: ShipLocations
        public async Task<IActionResult> Index()
        {
            return View(await _context.Admin.ToListAsync());
        }

        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult ChangePassword(Admin admin)
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Logout(Admin admin)
        {
           // FormsAuthentication.SignOut();
           // Session.Abandon();
            ModelState.Clear();
            return RedirectToAction("Login");
            //return PartialView("Login");         
        }

        [HttpPost]
        public ActionResult Changepassword(Admin login, string NewPassword)
        {
            using (StarMatrixContext db = new StarMatrixContext())
            {
                var detail = db.Admin.Where(x => x.Password == login.Password && x.Username == login.Username).FirstOrDefault();
                //var detail = db.Admins.Where(x => x.Username == login.Username && x.Password == login.Password && x.Status == true).ToList();

                if (detail != null)
                {
                    detail.Password = NewPassword;

                    db.SaveChanges();
                    ViewBag.Message = "Password Updated Successfully!";
                    ModelState.Clear();
                    return View("ChangePassword");

                }
                else
                {
                    ViewBag.Status = "Invalid Username or Password";
                }


            }

            return View(login);
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult SavePassword(Admin admin, string NewPassword, string ConfirmPassword)
        //{
        //    //string username = Request.Form["Username"];
        //    //string oldPass = Request.Form["OldPassword"];
        //    //string newPass = Request.Form["NewPassword"];
        //    //string conPass = Request.Form["ConfirmPassword"];


        //    var list = db.Admins.Where(x => x.Username == admin.Username && x.Password == admin.Password && x.Status == true).ToList();
        //    if (list.Count > 0)
        //    {
        //        if (NewPassword == ConfirmPassword)
        //        {
        //            foreach (var item in list)
        //            {
        //                admin.Password = NewPassword;
        //                admin.Email = item.Email;
        //                admin.Roles = item.Roles;
        //            }

        //            //db.Entry(admin).State = EntityState.Modified;
        //            //db.Entry(admin).State = EntityState.Modified;
        //            db.SaveChanges();

        //            Session.Abandon();
        //            ModelState.Clear();
        //            //return PartialView("Login");
        //            ViewBag.Status = "password change successfully.";
        //            return View("ChangePassword");
        //        }
        //        else
        //        {
        //            ViewBag.Status = "Confirm password not matched.";
        //            return View("ChangePassword");
        //        }
        //    }

        //    else
        //    {
        //        ViewBag.Status = "Invalid Username or Password";
        //        return View("ChangePassword");
        //    }
        //}

        //[AllowAnonymous]
        //[HttpGet]
        //public ActionResult GetLogin(Admin admin)
        //{
        //    //if (ModelState.IsValid)
        //    //{
        //    string userName = "";
        //    string password = "";
        //    if (admin.Username != null)
        //    {
        //        userName = admin.Username;
        //        password = admin.Password;

        //        var list = db.Admin.Where(x => x.Username == userName && x.Password == password && x.Status == true).ToList();
        //        if (list.Count > 0)
        //        {
        //            foreach (var item in list)
        //            {
        //                //Session["Roles"] = item.Roles;
        //            }
        //           // FormsAuthentication.SetAuthCookie(admin.Username, false);


        //           // Session["Admin"] = userName;
        //            return RedirectToAction("Index");
        //        }
        //        else
        //        {
        //            ViewBag.Status = "Invalid User";
        //            //Session["Admin"] = null;
        //            return PartialView("Login");
        //        }
        //    }

        //    return PartialView("Login");

        //    //}

        //    //return RedirectToAction("Login");

        //    //Session["Admin"] = null;
        //    //}
        //    //return PartialView("Login");
        //}

        // GET: Admin
        //[AllowAnonymous]
        //public async Task<ActionResult> Index()
        //{
        //    try
        //    {
        //        return View(await db.Admin.ToListAsync());
        //        //string s = Session["Admin"].ToString();

        //        //if (Session["Admin"] != null)
        //        //{
        //        //    return View(await db.Admin.ToListAsync());
        //        //}
        //        //else
        //        //{
        //        //    return RedirectToAction("Login");
        //        //}
        //    }
        //    catch { return RedirectToAction("Login"); }
        //}

        // GET: Admin/Details/5
        //public async Task<ActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Admin admin = await db.Admin.FindAsync(id);
        //    if (admin == null)
        //    {
        //       // return HttpNotFound();
        //    }
        //    return View(admin);
        //}

        // GET: Admin/Create
        [AllowAnonymous]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]        
        public async Task<IActionResult> Create(Admin admin)
        {
            if (ModelState.IsValid)
            {
                admin.DateAdded = DateTime.Now;
                admin.Ipaddress = Ipaddress.GetIpaddress();
                _context.Add(admin);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(admin);
        }


        // GET: Admin/Edit/5
        //public async Task<ActionResult> Edit(int? id)
        //{
        //    //if (id == null)
        //    //{
        //    //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    //}
        //    Admin admin = await db.Admin.FindAsync(id);
        //    if (admin == null)
        //    {
        //       // return HttpNotFound();
        //    }
        //    return View(admin);
        //}

        // POST: Admin/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> Edit(Admin admin)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(admin).State = EntityState.Modified;
        //        await db.SaveChangesAsync();
        //        return RedirectToAction("Index");
        //    }
        //    return View(admin);
        //}

        // GET: Admin/Delete/5
        //public async Task<ActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //       // return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Admin admin = await db.Admin.FindAsync(id);
        //    if (admin == null)
        //    {
        //        //return HttpNotFound();
        //    }
        //    return View(admin);
        //}

        // POST: Admin/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> DeleteConfirmed(int id)
        //{
        //    Admin admin = await db.Admin.FindAsync(id);
        //    db.Admin.Remove(admin);
        //    await db.SaveChangesAsync();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        [AllowAnonymous]
        [HttpGet]
        public ActionResult GetLogin(Admin admin)
        {
            //if (ModelState.IsValid)
            //{
            string userName = "";
            string password = "";
            if (admin.Username != null)
            {
                userName = admin.Username;
                password = admin.Password;

                var list = _context.Admin.Where(x => x.Username == userName && x.Password == password && x.Status == true).ToList();
                if (list.Count > 0)
                {
                    //foreach (var item in list)
                    //{
                    //    Session["Roles"] = item.Roles;
                    //}
                    //FormsAuthentication.SetAuthCookie(admin.Username, false);
                    //Session["Admin"] = userName;
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.Status = "Invalid User";
                    //Session["Admin"] = null;
                    return PartialView("Login");
                }
            }

            return PartialView("Login");

            //}

            //return RedirectToAction("Login");

            //Session["Admin"] = null;
            //}
            //return PartialView("Login");
        }
    }
}
