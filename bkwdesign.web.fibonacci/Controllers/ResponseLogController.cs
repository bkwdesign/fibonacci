using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace bkwdesign.web.math.Controllers
{
    public class ResponseLogController : ApiController
    {
        // GET api/responselog
        public ResponseLogViewModel Get()
        {
            ResponseLogViewModel vm = new ResponseLogViewModel();
            vm.RecentQueries =  Models.MathResponse.GetRecentQueries(10, ref MvcApplication.RequestLog);
            return vm;
        }

    }

    public class ResponseLogViewModel
    {
        public List<Models.MathResponse> RecentQueries;
    }
}
