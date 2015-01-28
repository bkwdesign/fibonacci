using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Reflection;

namespace bkwdesign.web.math
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static System.Data.DataTable RequestLog;

        protected void Application_Start()
        {
            RequestLogConfig.Init(ref RequestLog);

            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        /// <summary>
        /// On application quit - write out the request log to a file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Application_End(object sender, EventArgs e)
        {
            RequestLogConfig.PersistLog(RequestLog);

            //initial development to see if log is working...
            foreach (System.Data.DataRow dr in RequestLog.Rows)
            {
                Console.WriteLine(String.Format("{0},{1},{2},{3}", dr.ItemArray));
            }
        }

 
    }

   
}