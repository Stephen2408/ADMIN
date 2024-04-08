using CarManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManagement.Service.InvoiceService
{
    public interface IInvoice
    {
        Task<IEnumerable<Invoice>> GetAllInvoices();
        Task<Invoice> GetInvoiceById(int id);
        Task CreateInvoice(Invoice invoice);
        Task UpdateInvoice(Invoice invoice);
        Task DeleteInvoice(int id);
        Task<decimal> CalculateTotalCost(int invoiceId);
        Task UpdatePaymentStatus(int invoiceId);
        
    }
}
