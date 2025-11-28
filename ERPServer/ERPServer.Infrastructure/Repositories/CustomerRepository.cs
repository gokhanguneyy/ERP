using ERPServer.Domain.Entities;
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
    internal sealed class CustomerRepository : Repository<Customer, ApplicationDbContext>, ICustomerRepository
    {
        public CustomerRepository(ApplicationDbContext context) : base(context)
        {
        }

        // Normalde burada ICustomerRepository ve CustomerRepository arasında DependencyInjection yapmamız gerekirdi
        // yani services.builder<bla bla> şeklinde sisteme tanımlamamız gerekirdi fakat Infrastructe katmanı > DependencyInjection.cs
        // dosyasında bir "scan" yapılandırması var. Bu yapı, servisleri tarayıp gerekli dependencyInjection'ı otomatik yapıyor.
    }
}
