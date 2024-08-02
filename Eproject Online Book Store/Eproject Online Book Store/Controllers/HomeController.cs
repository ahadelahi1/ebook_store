using Microsoft.AspNetCore;

using System.Diagnostics;

using Eproject_Online_Book_Store.Models;

using Microsoft.AspNetCore.Mvc;

namespace Eproject_Online_Book_Store.Controllers
{
    public class HomeController : Controller
    {
     
        Connection db = new Connection();

        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Login(string email, string pass)
        {
            var result = db.Users.Any(x => x.Email == email && x.Password == pass);

            if (result)
            {
                var data = db.Users.Where(x => x.Email == email && x.Password == pass).FirstOrDefault();
                if (data != null)
                {
                    HttpContext.Session.SetString("name", data.Name);
                    

                    return RedirectToAction("Index");
                }
            }

            return View();
        }
        public IActionResult register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult register(string name,string email,string pass,string phone,string city)
        {

            User users = new User(0,name,email,pass,phone,city);

            db.Users.Add(users);

            db.SaveChanges();

            return View();
        }




        public IActionResult Index()
        {
            if(HttpContext.Session.GetString("name") != null)
            {
            TempData["name"] = HttpContext.Session.GetString("name");
            }
            return View();
        }

        public IActionResult logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        public IActionResult AddBooks()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBooks(string name,string Description,string Author,string Year,IFormFile image)
        {

            if (image != null)
            {


                var image_name = $"{Guid.NewGuid()}_{image.FileName}";
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Book_Image",image_name);
                using (FileStream stream = new FileStream(path, FileMode.Create))
                {
                    image.CopyTo(stream);
                }

            Books books = new Books(0,name,Description,Author,Year, image_name);

            db.Books.Add(books);
            }
            db.SaveChanges();
            return View();
        }


        public IActionResult Shop()
        {
            return View();
        }


       
        public IActionResult Contact()
        {
            return View();
        }

       

        public IActionResult Detail()
        {
            return View();
        }
        public IActionResult Checkout()
        {
            return View();
        }

        public IActionResult cart()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult History()
        {
            return View();
        }

        public IActionResult Biography()
        {
            return View();
        }

        public IActionResult Science()
        {
            return View();
        }

        public IActionResult Novels()
        {
            return View();
        }

        public IActionResult Utility()
        {
            return View();
        }












    }
}