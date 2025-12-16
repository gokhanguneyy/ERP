using ERPServer.Domain.Repositories;
using ERPServer.Infrastructure.Context;
using GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPServer.Infrastructure.Repositories
{
    internal sealed class InvoiceDetailRepository : Repository<InvoiceDetail, ApplicationDbContext>, IInvoiceDetailRepository
    {
        public InvoiceDetailRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
