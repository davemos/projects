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
            return View();
        }

        public ActionResult Calculator(HomeViewModel model)
        {
            HomeViewModel homeViewModel = new HomeViewModel();
            BaZiCalculator.Models.BaZiCalculator baZiCalculator = new Models.BaZiCalculator(Convert.ToDateTime(model.BirthDate), model.BirthTime);

            homeViewModel.FourPillarsResult = baZiCalculator.FourPillarsResult;
            homeViewModel.ElementTotals = baZiCalculator.ElementTotals;
            homeViewModel.TotalYin = baZiCalculator.TotalYin;
            homeViewModel.TotalYang = baZiCalculator.TotalYang;
            homeViewModel.YinYangMeridianResult = baZiCalculator.YinYangMeridianResult;
            homeViewModel.BirthDate = baZiCalculator.BirthDate;
            homeViewModel.BirthDay = baZiCalculator.BirthDay;
            homeViewModel.BirthMonth = baZiCalculator.BirthMonth;
            homeViewModel.BirthTime = baZiCalculator.BirthTime;
            homeViewModel.BirthYear = baZiCalculator.BirthYear;

            return View(homeViewModel);
        }
    }
}
