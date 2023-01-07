using BootShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.ObjectModel;

namespace BootShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Collection<ProductVariant> productVariants = new Collection<ProductVariant>();
            productVariants.Add(new ProductVariant(
                1,
                "Benjamin Velcro Dark Grey",
                "Tyhle botky mají styl! Kožené barefoot tenisky vhodné na užší až normální nožku Vyrobené z kvalitní hladké kůže v kombinaci s textilem. Tenká podešev přesahuje přesprsty, aby byla botka chráněna před poškozením.",
                579,
                699,
                true,
                "Tmavě modrá",
                "Do deště, turistické",
                "Guma",
                "Chlapecké",
                "BG004-001",
                "bota1.png",
                "bota2.png"));
            
            productVariants.Add(new ProductVariant(
                2,
                "Benjamin Velcro Dark Grey",
                "Tyhle botky mají styl! Kožené barefoot tenisky vhodné na užší až normální nožku Vyrobené z kvalitní hladké kůže v kombinaci s textilem. Tenká podešev přesahuje přesprsty, aby byla botka chráněna před poškozením.",
                579,
                699,
                true,
                "Tmavě modrá",
                "Do deště, turistické",
                "Guma",
                "Chlapecké",
                "BG004-001",
                "bota1.png",
                "bota2.png"));

            productVariants.Add(new ProductVariant(
                3,
                "Benjamin Velcro Dark Grey",
                "Tyhle botky mají styl! Kožené barefoot tenisky vhodné na užší až normální nožku Vyrobené z kvalitní hladké kůže v kombinaci s textilem. Tenká podešev přesahuje přesprsty, aby byla botka chráněna před poškozením.",
                579,
                699,
                true,
                "Tmavě modrá",
                "Do deště, turistické",
                "Guma",
                "Chlapecké",
                "BG004-001",
                "bota1.png",
                "bota2.png"));

            productVariants.Add(new ProductVariant(
                4,
                "Benjamin Velcro Dark Grey",
                "Tyhle botky mají styl! Kožené barefoot tenisky vhodné na užší až normální nožku Vyrobené z kvalitní hladké kůže v kombinaci s textilem. Tenká podešev přesahuje přesprsty, aby byla botka chráněna před poškozením.",
                579,
                699,
                true,
                "Tmavě modrá",
                "Do deště, turistické",
                "Guma",
                "Chlapecké",
                "BG004-001",
                "bota1.png",
                "bota2.png"));

            productVariants.Add(new ProductVariant(
                5,
                "Benjamin Velcro Dark Grey",
                "Tyhle botky mají styl! Kožené barefoot tenisky vhodné na užší až normální nožku Vyrobené z kvalitní hladké kůže v kombinaci s textilem. Tenká podešev přesahuje přesprsty, aby byla botka chráněna před poškozením.",
                579,
                699,
                true,
                "Tmavě modrá",
                "Do deště, turistické",
                "Guma",
                "Chlapecké",
                "BG004-001",
                "bota1.png",
                "bota2.png"));

            productVariants.Add(new ProductVariant(
                6,
                "Benjamin Velcro Dark Grey",
                "Tyhle botky mají styl! Kožené barefoot tenisky vhodné na užší až normální nožku Vyrobené z kvalitní hladké kůže v kombinaci s textilem. Tenká podešev přesahuje přesprsty, aby byla botka chráněna před poškozením.",
                579,
                699,
                true,
                "Tmavě modrá",
                "Do deště, turistické",
                "Guma",
                "Chlapecké",
                "BG004-001",
                "bota1.png",
                "bota2.png"));

            productVariants.Add(new ProductVariant(
                7,
                "Benjamin Velcro Dark Grey",
                "Tyhle botky mají styl! Kožené barefoot tenisky vhodné na užší až normální nožku Vyrobené z kvalitní hladké kůže v kombinaci s textilem. Tenká podešev přesahuje přesprsty, aby byla botka chráněna před poškozením.",
                579,
                699,
                true,
                "Tmavě modrá",
                "Do deště, turistické",
                "Guma",
                "Chlapecké",
                "BG004-001",
                "bota1.png",
                "bota2.png"));

            productVariants.Add(new ProductVariant(
                8,
                "Benjamin Velcro Dark Grey",
                "Tyhle botky mají styl! Kožené barefoot tenisky vhodné na užší až normální nožku Vyrobené z kvalitní hladké kůže v kombinaci s textilem. Tenká podešev přesahuje přesprsty, aby byla botka chráněna před poškozením.",
                569,
                699,
                true,
                "Tmavě modrá",
                "Do deště, turistické",
                "Guma",
                "Chlapecké",
                "BG004-001",
                "bota1.png",
                "bota2.png"));


            ViewBag.ProductVariantCollection = productVariants;

            return View();
        }
    }
}

