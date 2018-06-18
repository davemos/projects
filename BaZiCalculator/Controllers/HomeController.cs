using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using BaZiCalculator.Models;

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

            DataLoad dataLoad = new DataLoad();
            List <TwelveStageGrowthCycleChart> twelveStageGrowthCycleChart = dataLoad.LoadTwelveStageGrowthCycleChartData();
            List <ChineseCalendarChart> chineseCalendarChart = dataLoad.LoadChineseCalendarChartData();
            List <DayBinomialsChart> dayBinomialsChart = dataLoad.LoadDayBinomialsChartData();
            List <HourStemAndBranchChart> hourStemAndBranchChart = dataLoad.LoadHourStemAndBranchChartData();
            List <HiddenElementsChart> hiddenElementsChart = dataLoad.LoadHiddenElementsChartData();
            List <LeapYearMonthBinomialChart> leapYearMonthBinomialChart = dataLoad.LoadLeapYearMonthBinomialChartData();
            List <MonthBinomialChart> monthBinomialChart = dataLoad.LoadMonthBinomialChartData();
            List <StemsAndBranchesCycleOf60> stemsAndBranchesCycleOf60 = dataLoad.LoadStemsAndBranchesCycleOf60Data();
            List <YinYangMeridianChart> yinYangMeridianChart = dataLoad.LoadYinYangMeridianChartData();
            return View();
        }
    }
}
