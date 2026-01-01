using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Features.Product.Commands
{
    public class CreateProductCommand : IRequest<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Rate { get; set; }

        internal class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, int>
        {
            public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
            {
                // Here you would typically add code to save the product to a database
                // For demonstration purposes, we'll just return a dummy product ID
                return 1;
            }
        }
    }
}
