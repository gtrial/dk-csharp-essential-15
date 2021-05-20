namespace task03
{
    public struct Price
    {
        public string ProductName { get; set; }
        public string ShopName { get; set; }
        public double ProductPrice { get; set; }

        public Price(string name, string shop, double price)
        {
            ProductName = name;
            ShopName = shop;
            ProductPrice = price;
        }
    }
}