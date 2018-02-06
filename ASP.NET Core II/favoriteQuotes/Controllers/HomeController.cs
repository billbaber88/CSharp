using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using DbConnection;

namespace favoriteQuotes.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            List<Dictionary<string, object>> AllQuotes = DbConnector.Query("SELECT * FROM historicalquotes");
            ViewBag.Quotes = AllQuotes;
            return View();
        }

        [HttpPost]
        [Route("createQuote")]
        public IActionResult createQuote(string name, string quote)
        {
            string stringName = '"' + name + '"';
            string stringQuote = '"' + quote + '"';
            string query = $"INSERT INTO historicalquotes(name, quote, created_at)VALUES({stringName}, {stringQuote}, NOW());";

            DbConnector.Execute(query);
            return RedirectToAction("Index");
        }
    }
}
