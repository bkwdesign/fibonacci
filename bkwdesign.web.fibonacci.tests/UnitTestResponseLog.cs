using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using bkwdesign.web.math.extensions;

namespace bkwdesign.web.math.tests
{
    [TestClass]
    public class UnitTestResponseLog
    {
        [TestInitialize]
        public void Setup()
        {
            RequestLogConfig.Init(ref MvcApplication.RequestLog);
        }

        [TestMethod, TestCategory("DataTable")]
        public void ResponseLogTest1()
        {
            
            Assert.IsNotNull(MvcApplication.RequestLog, "The request log datatable should have been created");

        }

        [TestMethod, TestCategory("DataTable")]
        public void ResponseLogTest2()
        {
            Models.MathResponse mr = new Models.MathResponse { UserQuery = 0, Response = 0, RequestOrigin = "TEST" };
            mr.LogRequest();

            mr = new Models.MathResponse { UserQuery = 1, Response = 1, RequestOrigin = "TEST2" };
            mr.LogRequest();

            Assert.IsTrue(MvcApplication.RequestLog.Rows.Count > 0, "After logging a request, the datatable should have rows in it");

        }

        [TestMethod, TestCategory("DataTable")]
        public void ResponseLogTest3()
        {
            if (MvcApplication.RequestLog.Rows.Count == 0)
                ResponseLogTest2();//put some rows if not any detected...

            Models.MathResponse mr = MvcApplication.RequestLog.Rows[0].ItemArray.ToMathResponse();

            Assert.IsNotNull(mr, "The extension method should not have returned a null MathResponse object");

        }
    }
}
