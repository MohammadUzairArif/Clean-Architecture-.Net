using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Features.Product.Queries
{
    public class GetAllProductQuery : IRequest<IEnumerable<Product>>
    {
        internal class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, IEnumerable<Product>>
        {
            public async Task<IEnumerable<Product>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
            {
                // Here you would typically add code to retrieve products from a database
                // For demonstration purposes, we'll return a dummy list of products
                var list = new List<Product>();
                for (int i = 0;i<100;i++)
                {
                    var product = new Product
                    {
                        Name = $"Product {i + 1}",
                        Description = $"Description for Product {i + 1}",
                        Rate = (i + 1) * 10

                        
                    };
                    list.Add(product);
                   


                }
                return list;

            }
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Rate { get; set; }

    }
}
