using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using K22CNTT2_TRANVANMINH_2210900112.Models;

namespace K22cntt2_TrVanMinh_2210900112.Controllers
{
    public class SachController : Controller
    {
        private CuaHangSachEntities db = new CuaHangSachEntities();

        public ActionResult DanhSachTheoTheLoai(int theLoaiId)
        {
            var sachTheoTheLoai = db.Saches.Where(s => s.MaTheLoai == theLoaiId).ToList();
            ViewBag.TenTheLoai = db.TheLoais.Find(theLoaiId)?.TenTheLoai;
            return View(sachTheoTheLoai);
        }
    }
}
