namespace BootShop.Models
{
    public class Size
    {
        private int id;

        public Size(int id)
        {
            this.id = id;
        }

        public int GetSizeId()
        {
            return this.id;
        }
    }
}
