using CarManagement.Model;
using CarManagement.Repository.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManagement.Service.InvoiceService
{
   /* public class InvoiceService : IInvoice
    {
        private readonly ApplicationDbContext _context;

        public InvoiceService(ApplicationDbContext context)
        {
            _context = context;
        }
        public Task<decimal> CalculateTotalCost(int invoiceId)
        {
            var invoice = _context.Invoices.FirstOrDefault(i => i.Id == invoiceId);
            if (invoice != null)
            {
                decimal totalCost = 0;

                // Tính 30% tiền xe làm cọc
                decimal deposit = invoice.Car.car_price * 0.3m;
                totalCost += deposit;

                // Kiểm tra nếu đã thanh toán 30%
                if (invoice.PaymentStatus == "Paid 30%")
                {
                    // Tính tổng tiền còn lại 70% của tiền xe và thêm 10% thuế VAT
                    decimal remainingAmount = (invoice.Car.car_price * 0.7m) * 1.1m;
                    totalCost += remainingAmount;
                }

                return Task.FromResult(totalCost);
            }
            // Trả về một Task với giá trị mặc định 0 nếu không tìm thấy hóa đơn
            return Task.FromResult(0m);
        }

        public async Task CreateInvoice(Invoice invoice)
        {
            _context.Invoices.Add(invoice);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteInvoice(int id)
        {
            var invoice = await _context.Invoices.FindAsync(id);
            if (invoice != null)
            {
                _context.Invoices.Remove(invoice);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Invoice>> GetAllInvoices()
        {
            return await _context.Invoices.ToListAsync();
        }

        public async Task<Invoice> GetInvoiceById(int id)
        {
            return await _context.Invoices.FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task UpdateInvoice(Invoice invoice)
        {
            _context.Invoices.Update(invoice);
            await _context.SaveChangesAsync();
        }

        public async Task UpdatePaymentStatus(int invoiceId)
        {
            var invoice = await _context.Invoices.FindAsync(invoiceId);
            if (invoice == null)
                throw new ArgumentException("Invoice not found");

            invoice.PaymentStatus = "Paid"; // Cập nhật trạng thái thanh toán
            await _context.SaveChangesAsync();
        }
    }*/
}
