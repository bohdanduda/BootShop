namespace BootShop.Models
{
    public class ProductVariant
    {
        public string Name = "Benjamin Velcro Dark Grey";

        public string Description = "Tyhle botky mají styl! Kožené barefoot tenisky vhodné na užší až normální nožku Vyrobené z kvalitní hladké kůže v kombinaci s textilem. Tenká podešev přesahuje přesprsty, aby byla botka chráněna před poškozením.";

        public int DiscountPrice = 569;

        public int StockPrice = 699;

        public bool InStock = true;

        public string ProductColor = "Tmavě modrá";

        public string ProductType = "Do deště, turistické";

        public string ProductMaterial = "Guma";

        public string ProductUse = "Chlapecké";

        public string ProductCode = "BG004-001";


        public string GetName()
        {
            return this.Name;
        }

        public string GetDescription()
        {
            return this.Description;
        }

        public int GetDiscountPrice()
        {
            return this.DiscountPrice;
        }

        public int GetStockPrice()
        {
            return this.StockPrice;
        }

        public string GetInStock()
        {
            if (this.InStock)
            {
                return "Skladem";
            }
            else
            {
                return "Není Skladem";
            }
        }

        public string GetColor()
        {
            return this.ProductColor;
        }

        public string GetType()
        {
            return this.ProductType;
        }

        public string GetMaterial()
        {
            return this.ProductMaterial;
        }

        public string GetUse()
        {
            return this.ProductUse;
        }

        public string GetCode()
        {
            return this.ProductCode;
        }





    }
}
