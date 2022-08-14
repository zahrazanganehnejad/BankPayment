using System.ComponentModel.DataAnnotations;

namespace BankPayment.Models.ViewModels
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }
        [Required]
        public int Sum { get; set; }
        public bool IsFinaly { get; set; }
        public List<OrderDetail> orderDetails { get; set; }
    }
}
