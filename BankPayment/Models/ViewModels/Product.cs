using System.ComponentModel.DataAnnotations;

namespace BankPayment.Models.ViewModels
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Price { get; set; }
        public string ImageName { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
