using ERPServer.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPServer.Domain.Entities
{
    public sealed class RecipeDetail : Entity
    {
        public Guid RecipeId { get; set; }
        public Guid ProductId { get; set; }
        public Product? product { get; set; }
        public decimal Quantity { get; set; }
    }
}
