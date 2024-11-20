using Microsoft.AspNetCore.Mvc;
using Task1.Models;

namespace Task1.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            var products = GetProducts();
            return View(products);
        }

        private List<Products> GetProducts()
        {
            // Sa
            return new List<Products>
            {
                new Products { ImageUrl = "Images/img4.png", Name = "LEVN Headset with Mic", Price = 25.99 },
                new Products { ImageUrl = "Images/img5.png", Name = "Crayola Crayon Tub", Price = 25.50 },
                new Products { ImageUrl = "Images/img1.png", Name = "Crayola Bulk Colored Pencils", Price = 44.99 },
                new Products { ImageUrl = "Images/img2.png", Name = "EKSA E1000 USB Gaming Headset", Price = 24.99 },
                new Products { ImageUrl = "Images/img3.png", Name = "Crayola Colored Pencils Classpack", Price = 47.09 },
                new Products { ImageUrl = "Images/img12.png", Name = "Dare to Lead: Brave Work", Price = 12.99 },
                ///////////////////////
        new Products { ImageUrl = "Images/img11.png", Name = "Electric Clipper", Price = 39.99, DiscountPrice = 38m, Description = "Electric Clipper with Attachments" },
        new Products { ImageUrl = "Images/img15.png", Name = "Men's Clipper", Price = 49.99, DiscountPrice = 70m, Description = "Rechargeable Men's Clipper" },
        new Products { ImageUrl = "Images/img16.png", Name = "Casual Shoes", Price = 32.99, DiscountPrice = 58m, Description = "Casual Sneakers - Black" },
        new Products { ImageUrl = "Images/img17.png", Name = "Skechers Men's GOWalk", Price = 119.99, DiscountPrice = 230m, Description = "Skechers Otis Shoes" },
        new Products { ImageUrl = "Images/img18.png", Name = "Skechers Sneakers", Price = 222, DiscountPrice = 350m, Description = "Skechers Sports Sneakers" },
        new Products { ImageUrl = "Images/img10.png", Name = "Air Stand Sneakers", Price = 299.99, DiscountPrice = 350m, Description = "Comfortable Air Stand Sneakers" },
        new Products { ImageUrl = "Images/img13.png", Name = "Men's Joggers", Price = 169.99, DiscountPrice = 278m, Description = "Under Armour Men's Joggers" },
        new Products { ImageUrl = "Images/img14.png", Name = "UA Tech T-Shirt", Price = 139.99, DiscountPrice = 230m, Description = "Under Armour Men's UA Tech T-Shirt" }
            };
        }
    }
}
