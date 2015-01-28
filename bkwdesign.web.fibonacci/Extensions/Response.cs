using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Runtime.CompilerServices;

namespace bkwdesign.web.math.extensions
{

    public static class Response
    {
        /// <summary>
        /// [UserQuery, Response, RequestOrigin, RequestDateTime]
        /// </summary>
        /// <param name="response"></param>
        /// <returns></returns>
        public static Object[] ToItemArray(this math.Models.MathResponse response)
        {
            return new Object[]{response.UserQuery, response.Response, response.RequestOrigin, response.RequestDateTime};
        }

        /// <summary>
        /// Helper for extracting DataTable's rows into proper MathResponse objects...
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static math.Models.MathResponse ToMathResponse(this Object[] array)
        {
            return new math.Models.MathResponse { UserQuery = (long)array[0], Response = (long)array[1], RequestOrigin = (string)array[2], RequestDateTime = DateTime.Parse(array[3].ToString()) };
        }

        /// <summary>
        /// take response and save it's properties to a new row inside an in-memory DataTable
        /// </summary>
        /// <param name="response"></param>
        public static void LogRequest(this math.Models.MathResponse response)
        {
            lock (MvcApplication.RequestLog)
            {
                DataRow dr = MvcApplication.RequestLog.NewRow();
                dr.ItemArray = response.ToItemArray();
                MvcApplication.RequestLog.Rows.Add(dr);
            }
        }

        public static void CaptureOrigin(this math.Models.MathResponse response, System.Web.Mvc.Controller c)
        {
            response.RequestOrigin = c.HttpContext.Request.UserHostAddress;
        }
    }
}