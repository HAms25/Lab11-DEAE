namespace WebApplication1.Models
{
    public class Detail
    {
        public int DetailID { get; set; }
        public int Amount { get; set; }
        public float Price { get; set; }
        public float Subtotal { get; set; }
        public int InvoiceID { get; set; }
        public virtual Invoice Invoice { get; set; }
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }

    }
}
