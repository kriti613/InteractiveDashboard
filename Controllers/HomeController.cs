using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InteractiveDashboard.Models;

namespace InteractiveDashboard.Controllers
{
    public class HomeController : Controller
    {
        SalesFiveYearsEntities db = new SalesFiveYearsEntities();
        public ActionResult Index()
        {
            
            ViewBag.TotalYearSales = db.TotalYearSales.ToList();
            ViewBag.SelectAllMonthsYears = db.SelectAllMonthsYears.ToList();
            ViewBag.AllDetails2011 = db.AllDetails2011.ToList();
            ViewBag.AllDetails2012 = db.AllDetails2012.ToList();
            ViewBag.AllDetails2013 = db.AllDetails2013.ToList();
            ViewBag.AllDetails2014 = db.AllDetails2014.ToList();
            ViewBag.AllDetails2015 = db.AllDetails2015.ToList();
            ViewBag.CountryPercentageSales2011 = db.CountryPercentageSales2011.ToList();
            ViewBag.CountryPercentageSales2012 = db.CountryPercentageSales2012.ToList();
            ViewBag.CountryPercentageSales2013 = db.CountryPercentageSales2013.ToList();
            ViewBag.CountryPercentageSales2014 = db.CountryPercentageSales2014.ToList();
            ViewBag.CountryPercentageSales2015 = db.CountryPercentageSales2015.ToList();
            ViewBag.CountryGenderSales2011 = db.CountryGenderSales2011.ToList();
            ViewBag.CountryGenderSales2012 = db.CountryGenderSales2012.ToList();
            ViewBag.CountryGenderSales2013 = db.CountryGenderSales2013.ToList();
            ViewBag.CountryGenderSales2014 = db.CountryGenderSales2014.ToList();
            ViewBag.CountryGenderSales2015 = db.CountryGenderSales2015.ToList();
            ViewBag.ProductCategorySales2011 = db.ProductCategorySales2011.ToList();
            ViewBag.ProductCategorySales2012 = db.ProductCategorySales2012.ToList();
            ViewBag.ProductCategorySales2013 = db.ProductCategorySales2013.ToList();
            ViewBag.ProductCategorySales2014 = db.ProductCategorySales2014.ToList();
            ViewBag.ProductCategorySales2015 = db.ProductCategorySales2015.ToList();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}