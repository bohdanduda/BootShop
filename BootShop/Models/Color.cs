namespace BootShop.Models
{
    public class Color
    {
        private int id;
        private string name;
        private string hexCode;

        public Color( int id, string name, string hexCode)
        {
            this.id = id;
            this.name = name;
            this.hexCode = hexCode;
        }

        public int GetId()
        {
            return id;
        }

        public string GetName()
        {
            return name;
        }

        public string GetHexCode()
        {
            return this.hexCode;
        }
    }
}
