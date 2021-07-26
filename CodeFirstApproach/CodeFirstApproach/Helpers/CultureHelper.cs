using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.SessionState;

namespace CodeFirstApproach.Helpers
{
    public class CultureHelper
    {
        protected HttpSessionState session;
        public CultureHelper(HttpSessionState httpSessionState)
        {
            session = httpSessionState;
        }
        public static int CurrentCulture
        {
            get
            {
                if(Thread.CurrentThread.CurrentCulture.Name == "hi-IN")
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                if(value == 1)
                {
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("hi-IN");
                }
            }
        }
    }
}