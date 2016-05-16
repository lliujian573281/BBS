using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BBS.BLL;
namespace Web.Admin.ashx
{
    /// <summary>
    /// zhuce 的摘要说明
    /// </summary>
    public class zhuce : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            string json = "{'info':'注册失败','ID':-1}";


            string txtUname = context.Request.Form["uname"]; //保存文本框对象，提高效率
            string txtUPassword = context.Request.Form["upassword"];
            string txtUEmail = context.Request.Form["ermail"];
            string txtUBirthday = context.Request.Form["ubirthday"];
            string txtUsex1 = context.Request.Form["ubirthday"];bool txtUsex = true; if (txtUsex1 == "女") { txtUsex = false; }
            int txtUClass =int.Parse( context.Request.Form["uclass"]);
            string txtUStatement = context.Request.Form["ustatement"];
            string txtURegDate = context.Request.Form["uregdate"];
            int txtUState =int.Parse( context.Request.Form["ustate"]);
            int txtUPoint =int.Parse( context.Request.Form["upoint"]);

            

            BBS.BLL.BBSUsers bll = new BBS.BLL.BBSUsers();
            int n = bll.zhuce(txtUname, txtUPassword, txtUEmail, txtUBirthday, txtUsex, txtUClass, txtUStatement, txtURegDate, txtUState, txtUPoint);
            //返回单个文字信息
            if (n > 0)
            {
                json = "{'info':'注册成功！','ID':" + n + "}";
                context.Session["ID"] = n;
            }
            context.Response.Write(json);
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