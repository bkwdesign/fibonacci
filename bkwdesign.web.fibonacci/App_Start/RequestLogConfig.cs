using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bkwdesign.web.math
{
    public class RequestLogConfig
    {

        const string REQUESTLOG_FILENAME = "RequestLog.xml";

        public static void Init(ref System.Data.DataTable dt)
        {
            string filePath = String.Format("{0}/{1}", GetExecutingPath(), REQUESTLOG_FILENAME);
            System.IO.FileInfo fi = new System.IO.FileInfo(filePath);

            if (fi.Exists)
            {
                System.Data.DataSet ds = new System.Data.DataSet("RequestLog");
                ds.ReadXml(filePath);

                dt = ds.Tables[0];//either load recents from xml
            }
            else
            {
                dt = new System.Data.DataTable("MathResponses");//or start afresh

                //yeah, I know.. sexier if I had used a list of mathresponse objects and done some linq magic
                //but.. faster for me at the moment to go with this
                dt.Columns.Add("UserRequest", Type.GetType("System.Int64"));
                dt.Columns.Add("Response", Type.GetType("System.Int64"));
                dt.Columns.Add("RequestOrigin", Type.GetType("System.String"));
                dt.Columns.Add("RequestDateTime", Type.GetType("System.DateTime"));
            }
        }

        public static void PersistLog(System.Data.DataTable dt)
        {
            System.Data.DataSet ds = new System.Data.DataSet("RequestLog");
            ds.Tables.Add(dt);
            string filePath = String.Format("{0}/{1}", GetExecutingPath(), REQUESTLOG_FILENAME);
            ds.WriteXml(filePath);
        }

        private static string GetExecutingPath()
        {
            return System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }
    }
}