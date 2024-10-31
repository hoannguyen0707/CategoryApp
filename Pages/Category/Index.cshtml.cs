using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CategoryApp.Models;

namespace CategoryApp.Pages.Category
{
    public class IndexModel : PageModel
    {
        private readonly List<PCategory> categories =
        [
            new () { Id = 1, Name = "Dog", Description = "Loyal and friendly companion"  },
            new () { Id = 2, Name = "Cat", Description = "Independent and playful" },
            new () { Id = 3, Name = "Bird", Description = "Colorful and sings beautifully" },
            new () { Id = 4, Name = "Fish", Description = "Quiet, easy-care pet"},
            new () { Id = 5, Name = "Rabbit", Description = "Gentle and soft-furred" }
        ];
        public required List<PCategory> Categories { get; set; }

        public void OnGet()
        {
            Categories = categories;
        }
    }
}
