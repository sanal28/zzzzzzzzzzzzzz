using ETLCenter.CommonLibrary;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace ETLCenter.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public JsonResult LoginData(string UserName, string UserPassword)
        {
            int employeeId;
            bool userType;
            try
            {
                ETLLoginService.ETLCenterLoginService loginService = new ETLLoginService.ETLCenterLoginService();
                loginService.Url = Constants.LoginService;
                string logDetails = loginService.Login(UserName, UserPassword);
                DataTable dt = JsonConvert.DeserializeObject<DataTable>(logDetails);
                employeeId = Convert.ToInt32(dt.Rows[0]["ID"]);
                Session["EmployeeID"] = employeeId;
                userType=Convert.ToBoolean(dt.Rows[0]["EmpISAdmin"]);
                return Json(new { id = employeeId,type = userType }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                CommonFunctions commonFun = new CommonFunctions();
                commonFun.ExceptionLog(ControllerContext.HttpContext, ex.Message, ex.TargetSite.Name,
                    Convert.ToString(ControllerContext.RouteData.Values["action"]),
                    Convert.ToString(ControllerContext.RouteData.Values["controller"]));
                commonFun = null;
                return Json(new { id=-1}, JsonRequestBehavior.AllowGet);
            }
            finally
            {
                Dispose();
            }
        }      
        public ActionResult Forgot()
        {
            return View();
        }
        public JsonResult ForgotPasswordSend(string emailId)
        {
            bool emailSendCheckFlag;
            try
            {
                ETLLoginService.ETLCenterLoginService forgotPasswordService = new ETLLoginService.ETLCenterLoginService();
                forgotPasswordService.Url = Constants.LoginService;
                emailSendCheckFlag = forgotPasswordService.ForgotPassword(emailId);
                return Json(new { flag = emailSendCheckFlag }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                CommonFunctions commonFun = new CommonFunctions();
                commonFun.ExceptionLog(ControllerContext.HttpContext, ex.Message, ex.TargetSite.Name,
                    Convert.ToString(ControllerContext.RouteData.Values["action"]),
                    Convert.ToString(ControllerContext.RouteData.Values["controller"]));
                commonFun = null;
                return Json(new { flag = 0 }, JsonRequestBehavior.AllowGet);
            }
            finally
            {
                Dispose();
            }
        }
        public ActionResult Logout()
        {
            Session.RemoveAll();
            Session["EmployeeID"] = null;
            return RedirectToAction("Login");
        }
        public ActionResult Help()
        {
            return View();
        }
        public ActionResult Support()
        {
            return View();
        }

        public JsonResult EtlSupport(String userName,string emailId, string message)
        {
            bool supportSendFlag;
            try
            {
                ETLLoginService.ETLCenterLoginService supportService = new ETLLoginService.ETLCenterLoginService();
                supportService.Url = Constants.LoginService;
                supportSendFlag=supportService.Support(userName, emailId, message);
                return Json(new { flag = supportSendFlag }, JsonRequestBehavior.AllowGet);
            }
            catch(Exception ex)
            {
                CommonFunctions commonFun = new CommonFunctions();
                commonFun.ExceptionLog(ControllerContext.HttpContext, ex.Message, ex.TargetSite.Name,
                    Convert.ToString(ControllerContext.RouteData.Values["action"]),
                    Convert.ToString(ControllerContext.RouteData.Values["controller"]));
                commonFun = null;
                return Json(new { flag=-1 }, JsonRequestBehavior.AllowGet);
            }
            finally
            {
                Dispose();
            }
        }
        public ActionResult Reset(string userId)
        {

            ViewBag.encryptUserId = userId;
            return View();
        }
        public JsonResult ResetPassword(string password,string encryptId)
        {
            int isResetFlag;
            try
            {

                ETLLoginService.ETLCenterLoginService resetPassword = new ETLLoginService.ETLCenterLoginService();
                resetPassword.Url = Constants.LoginService;
                isResetFlag = resetPassword.RestPassword(encryptId, password);

                return Json(new { flag = isResetFlag }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {

                CommonFunctions commonFun = new CommonFunctions();
                commonFun.ExceptionLog(ControllerContext.HttpContext, ex.Message, ex.TargetSite.Name,
                Convert.ToString(ControllerContext.RouteData.Values["action"]),
                Convert.ToString(ControllerContext.RouteData.Values["controller"]));
                commonFun = null;
                return Json(new { flag = -1 }, JsonRequestBehavior.AllowGet);
            }
            finally {

                Dispose();
            }
            
        }
    }
}