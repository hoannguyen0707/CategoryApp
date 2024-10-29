using CategoryApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CategoryApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly List<Category> categories =
        [
            new () { Id = 1, Name = "Dog", Description = "Loyal and friendly companion"  },
            new () { Id = 2, Name = "Cat", Description = "Independent and playful" },
            new () { Id = 3, Name = "Bird", Description = "Colorful and sings beautifully" },
            new () { Id = 4, Name = "Fish", Description = "Quiet, easy-care pet"},
            new () { Id = 5, Name = "Rabbit", Description = "Gentle and soft-furred" }
        ];

        public IActionResult Index()
        {
            return View(categories);
        }
    }
}
