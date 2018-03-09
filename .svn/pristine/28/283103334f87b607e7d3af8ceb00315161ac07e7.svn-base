using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ETLCenter.CommonLibrary
{
    public class CommonFunctions
    {

        public void ExceptionLog(HttpContextBase Context, string ErrorMessage, string MethodName, string ActionName, string ControllerName)
        {
            try
            {
                
                string FilePath = Context.Server.MapPath("~/Logs/ExceptionLog/" + DateTime.Now.ToShortDateString() + ".txt");
                if (!File.Exists(FilePath))
                {
                    using (FileStream fs = new FileStream(FilePath, FileMode.Create))
                    {
                        //File Creation goes here
                    }
                }
                using (StreamWriter writer = new StreamWriter(FilePath, true))
                {
                    writer.WriteLine("Error Message : " + ErrorMessage);
                    writer.WriteLine("Method Name : " + MethodName);
                    writer.WriteLine("Action Name : " + ActionName);
                    writer.WriteLine("Controller Name : " + ControllerName);
                    writer.WriteLine("Date Time : " + DateTime.Now.ToString());
                    writer.WriteLine("---------------------------------------------------------------------------------");
                }
                
            }
            catch
            {
                
            }
        }
    }

    public class SessionAuthorizeAttribute : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            return (httpContext.Session["employeeID"] != null );
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Result = new RedirectToRouteResult(
                                  new RouteValueDictionary
                                  {
                                   { "action", "Login" },
                                   { "controller", "Login" }
                                  });
        }
    }
}