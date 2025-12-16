using ERPServer.Domain.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace ERPServer.Application.Features.Invoices.CreateInvoice
{
    public sealed record CreateInvoiceCommand(
        Guid CustomerId,
        int Type,
        DateOnly Date,
        string InvoiceNumber,
        List<InvoiceDetailDto> Details) : IRequest<Result<string>>;
}