using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BankPayment.Models.ViewModels;

namespace BankPayment.Data
{
    public class BankPaymentContext : DbContext
    {
        public BankPaymentContext(DbContextOptions<BankPaymentContext> options)
            : base(options)
        {
        }

        public DbSet<Order> Order { get; set; } = default!;
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<Product> Product { get; set; }

    }
}
