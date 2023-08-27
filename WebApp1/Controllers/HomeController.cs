using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp1.Models;
using WebApp1.Helper;
using System.Web;
using System.Linq;
using System.Collections.Generic;

namespace WebApp1.Controllers
{

    //1 action có 1 view 
    //1 controller có nhiều viiew
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {



            //    //cách 1: truyền bằng viewBag
            //    int a = 10;
            //    ViewBag.A = new MathHelp().TinhTong(5, 10);

            //    // cách 2 : truyền qua tham số của hàm view
            //    //return View(10);
            //    //var sv1 = new SinhVien();
            //    //sv1.Id = 23;
            //    //sv1.MaSo = " 2dfw";
            //    //sv1.HoVaTen = "Nguyễn Tiền Đạt";
            //    //sv1.Lop = "Sd17303";

            //    // Truyền cả class bằng viewBag
            //    //ViewBag.sv1 = sv1;


            //    //Truyền 1 List
            //    //Bước 1  khau báo mảng danh sách
            //    // Bước 2 Khai báo đới tượng trong danh sách
            //    //Bước 3 Đưa đối tượng vào return view
            //    // Bước 4 Khí báo model để đón dữ liệu bên view
            //    //Bước 5 đón dữ liệu bên view để hiển thị
            //    //List<SinhVien> dsSinhVien = new List<SinhVien>();
            //    //var sv1 = new SinhVien();
            //    //sv1.Id = 23;
            //    //sv1.MaSo = " 2dfw";
            //    //sv1.HoVaTen = "Nguyễn Tiền Đạt";
            //    //sv1.Lop = "Sd17303";
            //    //dsSinhVien.Add(sv1);

            //    //var sv2 = new SinhVien();
            //    //sv2.Id = 23;
            //    //sv2.MaSo = " 2d2342fw";
            //    //sv2.HoVaTen = "Nguyễn Tiền Đạ234t";
            //    //sv2.Lop = "Sd17323403";
            //    //dsSinhVien.Add(sv2);
            //    //return View(dsSinhVien);

            //    //1. Chuyển hướng cùng controller
            //    //return RedirectToAction("DangNhap");

            //    //2. chuyển hướn gkhasc controller
            //    //return RedirectToAction("DanhSachTinTuc", "TinTuc");

            //    //3. chuyển hướng với url
            //    // return Redirect("https://www.youtube.com/watch?v=l0MC7HKpXQg&list=PLPNDi-wPpMzgEZnBnAAijM-SS7SidP2jr&index=3");

            //    //4. chuyển hướng bằng routeName
            //    //return RedirectToRoute("Default");

            //    //Truyền bằng return

            var dsMay = new MayTinh().KhoiTao();
            return View(dsMay);

        }
        //public IActionResult SapXep()
        //{
        //    var ds2may = new MayTinh().KhoiTao().OrderBy(m => m.GiaBan).Take(2).ToList();
        //    return View(ds2may);
        //}
        public IActionResult SapXep()
        {
            var ds2may = new MayTinh().KhoiTao().OrderBy(m => m.GiaBan).Take(2).ToList();
            return View(ds2may);
        }
        //public int TinhTong(int a , int b)
        //{
        //    return a + b;
        //}
        public IActionResult SapXepGiamDan()
        {
            var dsgiamdan = new MayTinh().KhoiTao().OrderBy(m => m.GiaBan).ToList();
            return View(dsgiamdan);
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}