using MediatR;
using MediatRCqrs.Entities;
using MediatRCqrs.Repositories;

namespace MediatRCqrs.MedHandlers.Queries
{
    public class GetAllProductsQuery: IRequest<List<Product>>
    {
        public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, List<Product>>
        {
            private readonly IProductRepository productRepository;

            public GetAllProductsQueryHandler(IProductRepository productRepository)
            {
                this.productRepository = productRepository;
            }

            public Task<List<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
            {
                var products = productRepository.GetAllProducts();
                return Task.FromResult(products);
            }
        }
    }
}
