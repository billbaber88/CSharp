using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using loginRegistration.Models;

namespace loginRegistration.Controllers
{
    public class LoginController : Controller
    {
        private readonly DbConnector _dbConnector;
        public LoginController(DbConnector connect)
        {
            _dbConnector = connect;
        }

        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            List<Dictionary<string, object>> AllUsers = _dbConnector.Query("SELECT * FROM userbase");
            ViewBag.email = "";
            return View();
        }

        [HttpPost]
        [Route("Register")]
        public IActionResult signUp(RegUser model)
        {
            if (ModelState.IsValid)
            {
                string checkEmail = $"SELECT * FROM userbase WHERE(email = '{model.email}')";
                var emailExists = _dbConnector.Query(checkEmail);
                if (emailExists.Count == 0)
                {
                    string query = $"INSERT INTO userbase(name, email, password)VALUES('{model.name}','{model.email}','{model.password}')";
                    _dbConnector.Execute(query);
                    HttpContext.Session.SetString("user", model.name);
                    var sessionQuery = _dbConnector.Query(checkEmail);
                    int sessionId = (int)sessionQuery[0]["id"];
                    return RedirectToAction("Success");
                }
                else
                {
                    ViewBag.email = "Email already exists";
                    return View("Index");
                }
            }
            else
            {
                ViewBag.email = "";
                return View("Index");
            }

        }

        [HttpGet]
        [Route("success")]
        public IActionResult Success()
        {
            string user = HttpContext.Session.GetString("user");
            ViewBag.user = user;
            return View();
        }

        [HttpPost]
        [Route("signin")]
        public IActionResult Signin(LoginUser model)
        {
            if (ModelState.IsValid)
            {
                string query = $"SELECT * FROM userbase WHERE(email = '{model.email}')";
                var exists = _dbConnector.Query(query);
                if (exists.Count == 0)
                {
                    ViewBag.email = "Email not found";
                    return View("Login");
                }
                else
                {
                    string password = (exists[0]["password"]).ToString();
                    if (password != model.password)
                    {
                        ViewBag.password = "Invalid Password";
                        return View("Login");
                    }
                    else
                    {
                        int id = (int)exists[0]["id"];
                        HttpContext.Session.SetInt32("id", id);
                        string name = (exists[0]["name"]).ToString();
                        HttpContext.Session.SetString("user", name);
                        return RedirectToAction("Success");
                    }
                }
            }
            else
            {
                ViewBag.email = "";
                ViewBag.password = "";
                return View("Login");
            }
        }
    

        [HttpGet]
        [Route("login")]
        public IActionResult Login()
        {
            ViewBag.email = "";
            ViewBag.password = "";
            return View();
        }

        [HttpGet]
        [Route("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }



    }
}
