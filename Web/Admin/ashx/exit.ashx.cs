using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Admin.ashx
{
    /// <summary>
    /// exit 的摘要说明
    /// </summary>
    public class exit : IHttpHandler, System.Web.SessionState.IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Session["ID"] = null;//清空session
            context.Response.Write("Hello World");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}