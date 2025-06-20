namespace ProjectCafe
{
    public class CartItem
    {
        public string MenuID { get; set; }
        public string MenuName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Subtotal => Quantity * Price;
    }

}
