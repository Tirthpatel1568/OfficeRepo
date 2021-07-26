using CodeFirstApproach.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstApproach.Controllers
{
    public class BaseController : Controller
    {

        protected override void ExecuteCore()
        {
            int Culture = 0;
            if (this.Session == null || this.Session["CurrentCulture"] == null)
            {
                int.TryParse(System.Configuration.ConfigurationManager.AppSettings["Culture"], out Culture);
                this.Session["CurrentCulture"] = Culture;
            }
            else
            {
                Culture = (int)this.Session["CurrentCulture"];
            }
            CultureHelper.CurrentCulture = Culture;
            base.ExecuteCore();
        }
        protected override bool DisableAsyncSupport
        {
            get
            {
                return true;
            }
        }
    }
}