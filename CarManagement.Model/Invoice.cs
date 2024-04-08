using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManagement.Model
{
    public class Invoice
    {
        public int Id { get; set; }
        public decimal TotalCost { get; set; }
        public DateTime DateIssued { get; set; }
        public required string PaymentStatus { get; set; }
        public int CarId { get; set; }
        public required Car Car { get; set; }
        public int EmployeeId { get; set; }
        public required Employee Employee { get; set; }
        public int CustomerId { get; set; }
        public required Customer Customer { get; set; }
    }
}
