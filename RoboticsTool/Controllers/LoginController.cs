using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RoboticsToolData.Model;
using RoboticsTool.Models;
using RoboticsToolData.Repository;
using RoboticsTool.Common;

namespace RoboticsTool.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                if (!(string.IsNullOrEmpty(viewModel.Email) || string.IsNullOrEmpty(viewModel.Password)))
                {
                    LoginRepository objloginRep = new LoginRepository();
                    tblUserDetail objuserdetails = new tblUserDetail();
                    objuserdetails = objloginRep.GetUserForAuthentication(viewModel.Email);
                    if (objuserdetails != null)
                    {
                        string passwordHash = HashHelper.ComputeSaltedHash(viewModel.Password, objuserdetails.PasswordSalt);
                        if (string.Equals(passwordHash, objuserdetails.PasswordHash, StringComparison.Ordinal))// Validate User password;
                        {
                            SessionData.LoggedUserName = objuserdetails.UserName;
                            return RedirectToAction("GetAllUnProcessedRecords", "RoboticsProcess");

                        }
                        else
                        {
                            ViewBag.LoginMessage = "The Employee ID or password is incorrect";
                        }

                    }
                    else
                    {
                        ViewBag.LoginMessage = "The Employee ID or password is incorrect";
                    }
                }
            }
            return View();

        }

        public ActionResult LogOut()
        {
            Session.Abandon();


            return RedirectToAction("Login", "Login");
        }
    }
}