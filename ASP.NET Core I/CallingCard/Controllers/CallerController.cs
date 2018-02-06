using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace YourNamespace.Controllers
{
    public class HelloController : Controller
    {
        [HttpGetAttribute]
        public string Index()
        {
            return "Hello World!";
        }

        //The route below will display Json data based off of the url you type in.
        //localhost:5000/bob/bobson/123/blue will return 
        //{"firstName":"bob","lastName":"boson","age":123,"favoriteColor":"blue"}
        [HttpGet]
        [Route("{first}/{last}/{age}/{color}")]
        public JsonResult Card(string first, string last, int age, string color)
        {
            var caller = new {
                FirstName = first,
                LastName = last,
                Age = age,
                FavoriteColor = color
            };
            return Json(caller);
        }
    }
}