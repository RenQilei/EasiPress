using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasiPress.Controllers
{
    [Authorize/*(Users="admin")*/]  //这里使用Authorize来判断是否登录，没有则跳转至Login。-------原理待探明。
    public class AdminController : Controller
    {
        //
        // GET: /Admin/
        
        public ActionResult Index()
        {
            //没有仔细考虑Cookie问题
            
            return View();
        }
        
	}
}