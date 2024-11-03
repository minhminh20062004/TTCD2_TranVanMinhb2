// Controllers/AdminController.cs
using K22CNTT2_TRANVANMINH_2210900112.Models;
using System.Web.Mvc;

public class AdminController : Controller
{
    // GET: Admin/Login
    public ActionResult Login()
    {
        return View();
    }

    // POST: Admin/Login
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Login(AdminLoginModel model)
    {
        if (ModelState.IsValid)
        {
            // Kiểm tra thông tin đăng nhập
            // Thay thế đoạn này bằng logic của bạn để xác thực quản trị viên
            if (model.Username == "admin" && model.Password == "password") // Thay đổi với thông tin thực tế
            {
                // Đăng nhập thành công, có thể lưu thông tin vào Session hoặc Cookie
                Session["AdminUser"] = model.Username; // Lưu thông tin vào session
                return RedirectToAction("Index", "AdminHome"); // Chuyển hướng tới trang quản trị
            }
            else
            {
                ModelState.AddModelError("", "Tên đăng nhập hoặc mật khẩu không đúng.");
            }
        }

        return View(model);
    }

    // Đăng xuất
    public ActionResult Logout()
    {
        Session.Abandon(); // Xóa thông tin phiên làm việc
        return RedirectToAction("Login"); // Quay lại trang đăng nhập
    }
}
