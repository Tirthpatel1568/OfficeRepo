using BindCheckListToModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace BindCheckListToModel.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            CountryModel Cm = new CountryModel();
            Cm.CountryList = new List<Country>();
            Cm.CountryList = BindCountry();
            return View(Cm);
        }
        [HttpPost]
        public ActionResult Index(CountryModel cm)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Selected Country:- ").AppendLine();
            foreach (var item in cm.CountryList)
            {
                if(item.CheckedStatus == true)
                {
                    sb.Append(item.CountryName + ", ").AppendLine();
                }


            }
            ViewBag.Country = sb.ToString();
            ViewBag.isHomeChecked = cm.isHome;
            return View(cm);
        }
        public List<Country> BindCountry()
        {
            List<Country> _objcountry = new List<Country>();
            _objcountry.Add(new Country { countryId = 1, CountryName = "India" });
            _objcountry.Add(new Country { countryId = 2, CountryName = "Pakistan" });
            _objcountry.Add(new Country { countryId = 4, CountryName = "Sri Lanka" });
            _objcountry.Add(new Country { countryId = 5, CountryName = "Japan" });
            _objcountry.Add(new Country { countryId = 6, CountryName = "China" });
            return _objcountry;
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