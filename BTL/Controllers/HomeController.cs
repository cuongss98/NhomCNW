using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BTL.Models;
namespace BTL.Controllers
{
    public class HomeController : Controller
    {
        private CongnghewebContext _context;
        public HomeController()
        {
            _context = new CongnghewebContext();
        }
        public ActionResult Index(string searchString = "")
        {
            var sp = from l in _context.SanPham
                     select l;

            if (!String.IsNullOrEmpty(searchString))
            {
                sp = sp.Where(s => s.TenSanPham.Contains(searchString));
            }

            return View(sp);
        }
        public ActionResult LienHe()
        {
            return View();
        }
        public ActionResult ChiTietSanPham(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SanPham sp = _context.SanPham.Find(id);
            DanhMuc danhmuc = _context.DanhMuc.Find(id);
            if (sp == null)
            {
                return HttpNotFound();
            }
            return View(sp);
            return View();
        }
        // GET: /Link/Details/1
        public ActionResult DatHang()
        {
            return View();
        }
        public ActionResult ThanhToan()
        {
            return View();
        }
      
    }
}