using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using BaZiCalculator.Models;
using BaZiCalculator.ViewModels;

namespace BaZiCalculator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var mvcName = typeof(Controller).Assembly.GetName();
            var isMono = Type.GetType("Mono.Runtime") != null;

            ViewData["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
            ViewData["Runtime"] = isMono ? "Mono" : ".NET";

            HomeViewModel homeViewModel = new HomeViewModel();
            BaZiCalculator.Models.BaZiCalculator baZiCalculator = new Models.BaZiCalculator(new DateTime(1924,7,21), 1030);

            homeViewModel.FourPillarsResult = baZiCalculator.FourPillarsResult;
            homeViewModel.ElementTotals = baZiCalculator.ElementTotals;
            homeViewModel.TotalYin = baZiCalculator.TotalYin;
            homeViewModel.TotalYang = baZiCalculator.TotalYang;
            homeViewModel.YinYangMeridianResult = baZiCalculator.YinYangMeridianResult;

            return View(homeViewModel);
        }


    }
}
