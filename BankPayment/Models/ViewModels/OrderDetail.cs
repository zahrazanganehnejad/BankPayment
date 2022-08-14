using System.ComponentModel.DataAnnotations;

namespace BankPayment.Models.ViewModels
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }
        [Required]
        public int OrderId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int Count { get; set; }
        [Required]
        public int Price { get; set; }

        public Order order { get; set; }
        public Product product { get; set; }
    }
}
