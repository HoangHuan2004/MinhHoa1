using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MinhHoa1.Models;

namespace MinhHoa1.Controllers
{
    public class MayTinhController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult XuLy(MayTinhModels mt)
        {
            double Ketqua = 0;
            switch(mt.PhepTinh)
            {
                case "+":Ketqua = mt.So1 + mt.So2;break;
                case "-": Ketqua = mt.So1 - mt.So2; break;
                case "*": Ketqua = mt.So1 * mt.So2; break;
                case "/": Ketqua = mt.So1 / mt.So2; break;
            }
            ViewBag.KQ = Ketqua;
            return View();
        }
    }
}
