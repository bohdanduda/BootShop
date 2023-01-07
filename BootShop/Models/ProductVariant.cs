namespace BootShop.Models
{
    public class ProductVariant
    {
        private int id;

        private string name;

        private string description;

        private int discountPrice;

        private int stockPrice;

        private bool inStock;

        private string productColor;

        private string productType;

        private string productMaterial;

        private string productUse;

        private string productCode;

        private string mainPhotoPath;

        private string detailPhotoPath;

        public ProductVariant(int id, string name, string description, int discountPrice, int stockPrice, bool inStock, string productColor, string productType, string productMaterial, string productUse, string productCode, string mainPhotoPath, string detailPhotoPath)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.discountPrice = discountPrice;
            this.stockPrice = stockPrice;
            this.inStock = inStock;
            this.productColor = productColor;
            this.productType = productType;
            this.productMaterial = productMaterial;
            this.productUse = productUse;
            this.productCode = productCode;
            this.mainPhotoPath = mainPhotoPath;
            this.detailPhotoPath = detailPhotoPath;
        }

        public int GetId()
        {
            return this.id;
        }
        public string GetName()
        {
            return this.name;
        }

        public string GetDescription()
        {
            return this.description;
        }

        public int GetDiscountPrice()
        {
            return this.discountPrice;
        }

        public int GetStockPrice()
        {
            return this.stockPrice;
        }

        public string GetInStock()
        {
            if (this.inStock)
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
            return this.productColor;
        }

        public string GetType()
        {
            return this.productType;
        }

        public string GetMaterial()
        {
            return this.productMaterial;
        }

        public string GetUse()
        {
            return this.productUse;
        }

        public string GetCode()
        {
            return this.productCode;
        }
        
        public string GetMainPhotoPath()
        {
            return this.mainPhotoPath;
        }

        public string GetDetailPhotoPath()
        {
            return this.detailPhotoPath;
        }
    }
}
