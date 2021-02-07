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
            if (ModelState.IsValid)
            {
                BaZiCalculator.Models.BaZiCalculator baZiCalculator = new Models.BaZiCalculator(Convert.ToDateTime(model.BirthDate), model.BirthTime, model.NoBirthTime);

                homeViewModel.FourPillarsResult = baZiCalculator.FourPillarsResult;
                homeViewModel.ElementTotals = baZiCalculator.ElementTotals;
                homeViewModel.TotalYin = baZiCalculator.TotalYin;
                homeViewModel.TotalYang = baZiCalculator.TotalYang;
                homeViewModel.TotalYinValue = baZiCalculator.TotalYinValue;
                homeViewModel.TotalYangValue = baZiCalculator.TotalYangValue;
                homeViewModel.YinYangMeridianResult = baZiCalculator.YinYangMeridianResult;
                homeViewModel.BirthDate = baZiCalculator.BirthDate;
                homeViewModel.BirthDay = baZiCalculator.BirthDay;
                homeViewModel.BirthMonth = baZiCalculator.BirthMonth;
                homeViewModel.BirthTime = baZiCalculator.BirthTime;
                homeViewModel.BirthYear = baZiCalculator.BirthYear;
                string excess = ""; string deficient = "";
                if (homeViewModel.ElementTotals.WoodPercent > 25) excess += "Wood";
                if (homeViewModel.ElementTotals.FirePercent > 25) excess += (excess != "" ? " and Fire" : " Fire");
                if (homeViewModel.ElementTotals.EarthPercent > 25) excess += (excess != "" ? " and Earth" : " Earth");
                if (homeViewModel.ElementTotals.MetalPercent > 25) excess += (excess != "" ? " and Metal" : " Metal");
                if (homeViewModel.ElementTotals.WaterPercent > 25) excess += (excess != "" ? " and Water" : " Water");
                if (homeViewModel.ElementTotals.WoodPercent < 15) deficient += "Wood";
                if (homeViewModel.ElementTotals.FirePercent < 15) deficient += (deficient != "" ? " and Fire" : " Fire");
                if (homeViewModel.ElementTotals.EarthPercent < 15) deficient += (deficient != "" ? " and Earth" : " Earth");
                if (homeViewModel.ElementTotals.MetalPercent < 15) deficient += (deficient != "" ? " and Metal" : " Metal");
                if (homeViewModel.ElementTotals.WaterPercent < 15) deficient += (deficient != "" ? " and Water" : " Water");
                homeViewModel.StatementOfExcessDeficient = "This Profile is ";
                if (excess == "" && deficient == "") homeViewModel.StatementOfExcessDeficient += "Balanced.";
                if (excess != "")
                    homeViewModel.StatementOfExcessDeficient += "Excess in " + excess;
                if (deficient != "")
                {
                    if (excess != "") homeViewModel.StatementOfExcessDeficient += " and ";
                    homeViewModel.StatementOfExcessDeficient += "Deficient in " + deficient;
                }
                return View(homeViewModel);
            }

                return View("index", model);
        }
    }
}
